using FFMpegCore;
using FFMpegCore.Arguments;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MP4SubtitleMerger
{
    public class SubtitleInfo
    {
        const string SubtitleTimeSpanFormatter = @"hh\:mm\:ss\,fff";
        public byte[] RawData { get; set; }
        List<Subtitle> Subtitles { get; set; }
        public SubtitleInfo(List<Subtitle> subtitles, byte[] rawData)
        {
            Subtitles = subtitles;
            RawData = rawData;
        }

        public SubtitleInfo(List<MergedSubtitle> mergedSubtitles)
        {
            var query = from mergedSubtitle in mergedSubtitles
                        select new Subtitle(mergedSubtitle.From,
                        mergedSubtitle.To,
                        mergedSubtitle.Lines.Select(x => x.Text).ToList()
                        );
            Subtitles = query.ToList();
            RawData = new byte[] { };
        }

        public static List<MergedSubtitle>? Merge(SubtitleInfo? higherSubtitle, SubtitleInfo? lowerSubtitle, BackgroundWorkerArguments
            arguments)
        {
            if (higherSubtitle == null) return null;
            if (lowerSubtitle == null) return null;
            List<MergedSubtitle> result =
                InitialMerge(higherSubtitle, lowerSubtitle, arguments);
            PadWhenHigherOrLowerLinesEmpty(result);
            SortLines(result);
            result= Compact(result);
            UpdateFont(result, arguments);
            return result;
        }
        public string ToText(bool clearFormating)
        {
            if(Subtitles==null) return string.Empty;

            StringBuilder result = new StringBuilder();
            int subIndex = 1;
            foreach (Subtitle sub in Subtitles)
            {
                result.AppendLine(subIndex.ToString());
                result.Append(sub.From.ToString(SubtitleTimeSpanFormatter));
                result.Append(" --> ");
                result.AppendLine(sub.To.ToString(SubtitleTimeSpanFormatter));
                int lineIndex = 1;
                foreach (var line in sub.Lines)
                {
                    if(clearFormating)
                    {
                        result.Append(ClearFormating(line));
                    }
                    else
                        result.Append(line);
                    if (lineIndex != sub.Lines.Count || subIndex != Subtitles.Count)
                    {
                        result.AppendLine();
                    }
                    lineIndex++;
                }
                if (subIndex != Subtitles.Count)
                {
                    result.AppendLine();
                }
                subIndex++;
            }
            return result.ToString();
        }
        public static string ClearFormating(string line)
        {
            if (string.IsNullOrEmpty(line))
                return line;
            StringBuilder sb = new StringBuilder(line).Replace("<b>", string.Empty)
                .Replace("</b>", string.Empty)
                .Replace("{b}", string.Empty)
                .Replace("{/b}", string.Empty)
                .Replace("<i>", string.Empty)
                .Replace("</i>", string.Empty)
                .Replace("{i}", string.Empty)
                .Replace("{/i}", string.Empty)
                .Replace("<u>", string.Empty)
                .Replace("</u>", string.Empty)
                .Replace("{u}", string.Empty)
                .Replace("{/u}", string.Empty);
            var result = Regex.Replace(sb.ToString(), @"<font[^>]*>", string.Empty);
            result = Regex.Replace(result, @"</.*font.*>", string.Empty);
            return result;
    
        }
        public static SubtitleInfo FromText(string text, byte[] rawData)
        {
            List<Subtitle> subtitles = new List<Subtitle>();
            text = text.Trim();
            if (string.IsNullOrWhiteSpace(text))
            {
                return new SubtitleInfo(subtitles, rawData);
            }
            List<String> lines = new List<string>();
            using (StringReader sr = new StringReader(text))
            {
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    lines.Add(line.Trim());
                }
            }
            if (lines.Count() < 2)
            {
                throw new InvalidDataException("Starting time range not found in subtitle");
            }
            int lastTimeRangeLine = -1;
            Subtitle? currentSubtitle = null;
            for (int lineIndex = 0; lineIndex < lines.Count; lineIndex++)
            {
                var timeRanges = DetectTimeRangeLine(lines[lineIndex]);
                if (timeRanges != null)
                {
                    AssertLineIsNumber(lines[lineIndex - 1]);
                    if (lastTimeRangeLine == -1)
                    {
                        lastTimeRangeLine = lineIndex;
                        continue;
                    }
                    else
                    {
                        if (currentSubtitle == null)
                        {
                            var lastTimeRanges = DetectTimeRangeLine(lines[lastTimeRangeLine]);
                            if (lastTimeRanges != null)
                            {
                                currentSubtitle = new Subtitle(lastTimeRanges[0],lastTimeRanges[1],new List<string>());
                            }
                        }
                        if (currentSubtitle != null)
                        {
                            currentSubtitle.Lines = lines.Skip(lastTimeRangeLine + 1).Take(
                            lineIndex - 2 - lastTimeRangeLine - 1
                            ).ToList(); 
                            subtitles.Add(currentSubtitle);
                        }                        
                    }
                    lastTimeRangeLine = lineIndex;
                    currentSubtitle = new Subtitle(timeRanges[0], timeRanges[1], new List<string>());
                }
            }
            if (currentSubtitle != null)
            {
                if (lastTimeRangeLine == -1)
                {
                    currentSubtitle.Lines = lines.Skip(lastTimeRangeLine + 1).Take(
                            lines.Count - lastTimeRangeLine
                            ).ToList();
                }
                else
                {
                    currentSubtitle.Lines = lines.Skip(lastTimeRangeLine + 1).Take(
                            lines.Count - lastTimeRangeLine - 1
                            ).ToList();
                }
                subtitles.Add(currentSubtitle);
            }
            else if (lastTimeRangeLine != -1)
            {
                var timeRanges = DetectTimeRangeLine(lines[lastTimeRangeLine]);
                if(timeRanges!=null)
                {
                    currentSubtitle = new Subtitle(timeRanges[0], timeRanges[1],
                        lines.Skip(lastTimeRangeLine + 1).ToList());
                    subtitles.Add(currentSubtitle);
                }
            }

            return new SubtitleInfo(subtitles, rawData);
        }
        static List<TimeSpan>? DetectTimeRangeLine(string line)
        {
            var splits = line.Split(" --> ");
            if (splits.Length == 1) return null;
                List<TimeSpan> result = new List<TimeSpan>();
            foreach (var split in splits)
            {
                var text = split.Trim();
                TimeSpan timeSpan1;
                if (TimeSpan.TryParseExact(text, SubtitleTimeSpanFormatter,
                    CultureInfo.CurrentCulture, TimeSpanStyles.None,
                    out timeSpan1))
                {
                    result.Add(timeSpan1);
                }
            }
            if (result.Count < 2) return null;
            return result.OrderBy(x => x).Take(2).ToList();
        }
        static void AssertLineIsNumber(string line)
        {
            int temp;
            if (!int.TryParse(line, out temp))
            {
                throw new InvalidDataException(string.Format("Expecting number, found:{0}", line));
            }
        }
        static bool IsConsequential(SubtitleInfo subtitleInfo)
        {
            if (subtitleInfo == null)
                return true;
            else
            {
                Subtitle? lastSubtitle = null;
                if (subtitleInfo.Subtitles != null)
                {
                    foreach (var subtitle in subtitleInfo.Subtitles)
                    {
                        if (lastSubtitle != null)
                        {
                            //check for overlap
                            if (subtitle.From < lastSubtitle.To) return false;
                        }
                        //check for reverse
                        if (subtitle.To < subtitle.From) return false;

                        lastSubtitle = subtitle;
                    }                    
                }
                return true;
            }
        }
        static List<MergedSubtitle> InitialMerge(SubtitleInfo higherSubtitleInfo, SubtitleInfo lowerSubtitleInfo, BackgroundWorkerArguments arguments)
        {
            List<MergedSubtitle> result = new List<MergedSubtitle>();
            List<TimeSpan> timePoints = higherSubtitleInfo.Subtitles.Select(x => x.From)
                 .Union(higherSubtitleInfo.Subtitles.Select(x => x.To))
                 .Union(lowerSubtitleInfo.Subtitles.Select(x => x.From)
                 .Union(lowerSubtitleInfo.Subtitles.Select(x => x.To)))
                 .Distinct()
                 .OrderBy(x => x)
                 .ToList();
            bool isHigherSubtitleConsequential = IsConsequential(higherSubtitleInfo);
            bool isLowerSubtitleConsequential = IsConsequential(lowerSubtitleInfo);
            int higherSubtitleIndex = 0;
            int lowerSubtitleIndex = 0;

            for (int i = 0; i < timePoints.Count - 1; i++)
            {
                TimeSpan from = timePoints[i];
                TimeSpan to = timePoints[i + 1];
                Subtitle? higherSubtitle = null;
                int foundUpperSubtitleIndex = SubtitleIndexFromTime(higherSubtitleIndex,
                    higherSubtitleInfo, from, to, isHigherSubtitleConsequential);
                if (foundUpperSubtitleIndex != -1)
                {
                    higherSubtitleIndex = foundUpperSubtitleIndex;
                    higherSubtitle = higherSubtitleInfo.Subtitles[foundUpperSubtitleIndex];
                }

                Subtitle? lowerSubtitle = null;
                int foundLowerSubtitleIndex = SubtitleIndexFromTime(lowerSubtitleIndex,
                    lowerSubtitleInfo, from, to, isLowerSubtitleConsequential);
                if (foundLowerSubtitleIndex != -1)
                {
                    lowerSubtitleIndex = foundLowerSubtitleIndex;
                    lowerSubtitle = lowerSubtitleInfo.Subtitles[foundLowerSubtitleIndex];
                }
                if (higherSubtitle != null || lowerSubtitle != null)
                {
                    List<MergedSubtitleLine> subtitleLines = new List<MergedSubtitleLine>();

                    if (higherSubtitle != null)
                    {
                        subtitleLines.AddRange(
                            higherSubtitle.Lines
                            .Select(x => new MergedSubtitleLine(
                                arguments.ClearFormating? ClearFormating (x): x, SubtitleSource.Higher)));
                      

                    }

                    if (lowerSubtitle != null)
                    {
                        subtitleLines.AddRange(
                            lowerSubtitle.Lines
                            .Select(x => new MergedSubtitleLine(
                                arguments.ClearFormating ? ClearFormating(x) : x, SubtitleSource.Lower)));                        
                    }

                    result.Add(new MergedSubtitle(from,to,subtitleLines));
                }
            }
            return result;
        }
        //when one source is showing constant text and another source changes between has text to no text
        //by default the source that has the text will move up and down
        //find all subtitles with only one source and pad lines from other sources
        static void PadWhenHigherOrLowerLinesEmpty(List<MergedSubtitle> mergedSubtitles)
        {
            for (int i = 0; i < mergedSubtitles.Count; i++)
            {
                MergedSubtitle mergedSubtitle = mergedSubtitles[i];
                var sources = mergedSubtitle.Lines.Select(x => x.Source).ToList();
                if (sources.Count == 1)
                {
                    SubtitleSource otherSubtitleSource = (sources[0] == SubtitleSource.Higher )?
                        SubtitleSource.Lower : SubtitleSource.Higher;
                    List<MergedSubtitleLine>? linesToAdd = GetPaddedLines(i, sources[0], otherSubtitleSource, mergedSubtitles);
                    if (linesToAdd != null)
                    {
                        mergedSubtitle.Lines.AddRange(linesToAdd);
                    }
                }
            }
        }
        static List<MergedSubtitleLine>? GetPaddedLines(int subtitleIndex,
            SubtitleSource source,
            SubtitleSource otherSubtitleSource, List<MergedSubtitle> mergedSubtitles)
        {
            MergedSubtitle subtitle = mergedSubtitles[subtitleIndex];

            for (int i = subtitleIndex - 1; i >= 0; i--)
            {
                if (IsConsecutive(mergedSubtitles[i], mergedSubtitles[i + 1], source))
                {
                    if (MergedSubtitle.CompareLines(mergedSubtitles[i], mergedSubtitles[i + 1]))
                    {
                        return mergedSubtitles[i].Lines.Where(line => line.Source == otherSubtitleSource)
                            .ToList();

                    }
                }
                else
                {
                    break;
                }
            }

            for (int i = subtitleIndex + 1; i < mergedSubtitles.Count; i++)
            {
                if (IsConsecutive(mergedSubtitles[i - 1], mergedSubtitles[i], source))
                {
                    if (MergedSubtitle.CompareLines(mergedSubtitles[i], mergedSubtitles[i - 1]))
                    {

                        return mergedSubtitles[i].Lines.Where(line => line.Source == otherSubtitleSource)
                            .ToList();
                    }
                }
                else
                {
                    break;
                }
            }

            return null;
        }
        static void SortLines(List<MergedSubtitle> subtitles)
        {
            foreach (var subtitle in subtitles)
            {
                subtitle.Lines = subtitle.Lines.Where(x=>x.Source== SubtitleSource.Higher)
                    .Union(subtitle.Lines.Where(x => x.Source == SubtitleSource.Lower))
                    .ToList();
            }
        }
        static int SubtitleIndexFromTime(int currentSubtitleIndex,
            SubtitleInfo subtitleInfo, TimeSpan from, TimeSpan to, bool isConsequential)
        {
            int maxIndexToCheck;
            if (isConsequential)
            {
                maxIndexToCheck = int.Min(currentSubtitleIndex + 1, subtitleInfo.Subtitles.Count - 1);
            }
            else
            {
                maxIndexToCheck = subtitleInfo.Subtitles.Count - 1;
            }
            
            for (int i = currentSubtitleIndex; i <= maxIndexToCheck; i++)
            {
                var subtitle=subtitleInfo.Subtitles[i];
                bool fromInsideSubtitle = (from>=subtitle.From) && (from<=subtitle.To);
                bool toInsideSubtitle = (to>= subtitle.From) && (to<= subtitle.To); 
                if (fromInsideSubtitle && toInsideSubtitle)
                {
                    return i;
                }
            }

            return -1;
        }
        static bool IsConsecutive(MergedSubtitle left, MergedSubtitle right, SubtitleSource source)
        {
            if(left.To!=right.From) return false;
            var leftLines=left.Lines.Where(x=>x.Source==source).Select(x=>x.Text).ToList();
            var rightLines = right.Lines.Where(x => x.Source == source).Select(x => x.Text).ToList();
            bool result=leftLines.SequenceEqual(rightLines);
            return result;
        }
        static List<MergedSubtitle> Compact(List<MergedSubtitle> mergedSubtitles)
        {
            LinkedList<MergedSubtitle> result = new LinkedList<MergedSubtitle>();
            foreach (var mergedSubtitle in mergedSubtitles)
            {
                bool addCurrentSubtitle = true;
                if (result.Last!=null)
                {
                    MergedSubtitle lastAddedSubtitle = result.Last.Value;
                    if (!MergedSubtitle.CompareLines(lastAddedSubtitle, mergedSubtitle)
                        && lastAddedSubtitle.To == mergedSubtitle.From)
                    {
                        //combine
                        lastAddedSubtitle.To = mergedSubtitle.To;
                        addCurrentSubtitle = false;
                    }
                }

                if (addCurrentSubtitle)
                {
                    result.AddLast(mergedSubtitle);
                }
            }

            return result.ToList();

        }
        public static SubtitleInfo? FFMPEGReadSubtitleFromFile(string file, string? language, int streamIndex)
        {
            try
            {
                var tempFolder = Path.GetTempPath();
                var tempSubtitleFile = Path.Combine(tempFolder,
string.Format("{0}.{1}.srt", Path.GetFileName(file), language));
                //ffmpeg -y -i file -map 0:streamIndex -c subrip tempSubtitleFile 
                var argument = FFMpegArguments.FromFileInput(file)
                .OutputToFile(tempSubtitleFile, true/*-y*/, opt => opt.SelectStream(streamIndex)
                .WithCustomArgument("-c subrip")
                );
                var result = argument.ProcessSynchronously(true);
                var text = File.ReadAllText(tempSubtitleFile);
                var rawData = File.ReadAllBytes(tempSubtitleFile);
                return SubtitleInfo.FromText(text, rawData);

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public static SubtitleInfo? FFMPEGReadSubtitleFromFile(string file, SubtitleStream? subtitleStream)
        {
            if (subtitleStream == null) return null;
            return FFMPEGReadSubtitleFromFile(file, subtitleStream.Language, subtitleStream.Index);
        }

        public static SubtitleInfo? FFMPEGTransformSubtitle(SubtitleInfo? subtitleInfo, string file, string? language,
            string tempSubtitleTargetFile)
        {
            if (subtitleInfo == null) return null;
            try
            {
                var tempFolder = Path.GetTempPath();
                var tempSubtitleSourceFile = Path.Combine(tempFolder,
                    string.Format("{0}.{1}.srt", Path.GetFileName(file), language));
                File.WriteAllText(tempSubtitleSourceFile, subtitleInfo.ToText(false));

                var argument = FFMpegArguments.FromFileInput(tempSubtitleSourceFile)
                    .OutputToFile(tempSubtitleTargetFile, true/*-y*/, opt => opt.SelectStream(0).
                        WithCustomArgument(string.Format("-c subrip")));
                Debug.WriteLine(argument.Arguments);
                var result = argument.ProcessSynchronously(true);
                var text = File.ReadAllText(tempSubtitleTargetFile);
                var rawData = File.ReadAllBytes(tempSubtitleTargetFile);
                return SubtitleInfo.FromText(text, rawData);

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return null; 
            }
        }

        public static void FFMPEGInjectToFile(string file, BackgroundWorkerArguments arguments, 
            string relativePathToRoot, string outputVideoFileName, string tempSubtitleTargetFile, string language, IMediaAnalysis mediaInfo)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                int newStreamIndex = arguments.ReplaceLastTopRowLanguageTrackIfNotFirst ?
                    mediaInfo.SubtitleStreams.Count - 1 : mediaInfo.SubtitleStreams.Count;
                if (arguments.ReplaceLastTopRowLanguageTrackIfNotFirst)
                {
                    var replaceLanguageTrack = mediaInfo.SubtitleStreams.Where(s => s.CodecName != "dvd_subtitle"
                    && s.Language== arguments.ReplaceTrackLanguage).Last();
                    var replaceStreamIndex= replaceLanguageTrack.Index;
                    sb.AppendFormat("-map 0 -map -0:{0} -map 1 -c:v copy -c:a copy ", replaceStreamIndex);
                }
                else
                    sb.Append("-map 0 -map 1 -c:v copy -c:a copy ");
                
                for (int i = 0; i < newStreamIndex; i++)
                {
                    sb.AppendFormat("-c:s:{0} copy ", i);
                }
                sb.Append("-copy_unknown ");
                //ffmpeg does not support subrip in mp4
                sb.AppendFormat("-c:s:{0} mov_text ", newStreamIndex);
                sb.AppendFormat("-metadata:s:s:{0} language={1} ", newStreamIndex, language);
                if (arguments.SetAsDefault)
                {
                    for (int i = 0; i < newStreamIndex; i++) {
                        sb.AppendFormat("-disposition:s:s:{0} 0 ", i);
                    }
                    sb.AppendFormat("-disposition:s:s:{0} default ", newStreamIndex);
                }
#if DEBUG
                sb.Append("-loglevel debug -v verbose");
#endif

                var argument = FFMpegArguments.FromFileInput(file).
                    AddFileInput(tempSubtitleTargetFile)
                    .OutputToFile
                    (
                        outputVideoFileName, true/*-y*/, opt => opt.WithCustomArgument
                        (
                            sb.ToString()
                        )
                    );
                Debug.WriteLine(argument.Arguments);
                var result = argument.ProcessSynchronously(true);

            }
            catch (Exception ex)
            {                
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }
        static void UpdateFont(List<MergedSubtitle> result, BackgroundWorkerArguments arguments)
        {
            if (arguments == null) return;
            if (string.IsNullOrWhiteSpace(arguments.TopRowFontSize) && string.IsNullOrWhiteSpace(arguments.BottomRowFontSize)) return;
            foreach (MergedSubtitle subtitle in result)
            {
                UpdateFont(subtitle, arguments);
            }
        }
        static void UpdateFont(MergedSubtitle subtitle, BackgroundWorkerArguments arguments)
        {
            var subtitleLines = subtitle.Lines;
            int firstTopRowLine = -1;
            int lastTopRowLine = -1;
            int firstBottomRowLine = -1;
            int lastBottomRowLine = -1;
            for (int i = 0; i < subtitleLines.Count; i++)
            {
                var subtitleLine = subtitleLines[i];
                switch (subtitleLine.Source)
                {
                    case SubtitleSource.Higher:
                        if (firstTopRowLine == -1)
                            firstTopRowLine = i;
                        lastTopRowLine = i;
                        break;
                    case SubtitleSource.Lower:
                        if (firstBottomRowLine == -1)
                            firstBottomRowLine = i;
                        lastBottomRowLine = i;
                        break;
                };
            }

            if (!string.IsNullOrWhiteSpace(arguments.TopRowFontSize))
            {
                if (firstTopRowLine != -1)
                { 
                    subtitleLines[firstTopRowLine].Text = string.Format(
                    "<font size=\"{0}\">{1}", arguments.TopRowFontSize, subtitleLines[firstTopRowLine].Text);
                }
                if(lastTopRowLine!=-1)
                    subtitleLines[lastTopRowLine].Text = string.Format("{0}</font>", subtitleLines[lastTopRowLine].Text);
            }

            if (!string.IsNullOrWhiteSpace(arguments.BottomRowFontSize))
            {
                if(firstBottomRowLine!=-1)
                    subtitleLines[firstBottomRowLine].Text = string.Format(
                        "<font size=\"{0}\">{1}", arguments.BottomRowFontSize, subtitleLines[firstBottomRowLine].Text);
                if(lastBottomRowLine!=-1)
                    subtitleLines[lastBottomRowLine].Text = string.Format("{0}</font>", subtitleLines[lastBottomRowLine].Text);
            }
        }
    }
}
