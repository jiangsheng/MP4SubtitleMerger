using FFMpegCore;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.Enumeration;
using System.Linq;

namespace MP4SubtitleMerger
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void toolStripButtonDetectLanguages_Click(object sender, EventArgs e)
        {
            try
            {
                var files = Directory.EnumerateFiles(textBoxVideoPath.Text, "*.mp4");
                if (files.Count() == 0)
                    throw new FileNotFoundException("No mp4 file under specified folder");
                foreach (var file in files)
                {
                    FFOptions options = new FFOptions();
                    options.TemporaryFilesFolder = Path.GetTempPath();
                    options.BinaryFolder = textBoxFFMPEGPath.Text;
                    var mediaInfo = FFProbe.Analyse(file, options);
                    if (mediaInfo != null && mediaInfo.SubtitleStreams != null)
                    {
                        if (mediaInfo.SubtitleStreams.Count < 2)
                        {
                            continue;
                        }
                        textBoxTopRowLanguage.Text = mediaInfo.SubtitleStreams[0].Language;
                        textBoxBottomRowLanguage.Text = mediaInfo.SubtitleStreams[1].Language;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            textBoxFFMPEGPath.Text = Properties.Settings.Default.FFMPEGPath;
            textBoxVideoPath.Text = Properties.Settings.Default.InputPath;
            textBoxTopRowLanguage.Text = Properties.Settings.Default.TopRowLanguage;
            textBoxBottomRowLanguage.Text = Properties.Settings.Default.ButtonRowLanguage;
            checkBoxSetAsDefault.Checked = Properties.Settings.Default.SetCombinedSubtitleAsDefault;
            radioButtonExtractFiles.Checked = Properties.Settings.Default.CreateSeparateFilesChecked;
            radioButtonInjectToVideo.Checked = Properties.Settings.Default.InjectToVideo;
            textBoxOutputFolder.Text = Properties.Settings.Default.OutputFolder;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.FFMPEGPath = textBoxFFMPEGPath.Text;
            Properties.Settings.Default.InputPath = textBoxVideoPath.Text;
            Properties.Settings.Default.TopRowLanguage = textBoxTopRowLanguage.Text;
            Properties.Settings.Default.ButtonRowLanguage = textBoxBottomRowLanguage.Text;

            Properties.Settings.Default.SetCombinedSubtitleAsDefault = checkBoxSetAsDefault.Checked;
            Properties.Settings.Default.CreateSeparateFilesChecked = radioButtonExtractFiles.Checked;
            Properties.Settings.Default.InjectToVideo = radioButtonInjectToVideo.Checked;
            Properties.Settings.Default.OutputFolder = textBoxOutputFolder.Text;
            Properties.Settings.Default.Save();
        }

        private void toolStripButtonStart_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy) return;
                if (!Directory.Exists(textBoxFFMPEGPath.Text))
            {
                MessageBox.Show("Specified video folder does not exist");
                return;
            }
            if (!Directory.Exists(textBoxOutputFolder.Text))
            {
                MessageBox.Show("Specified output folder does not exist");
                return;
            }
            if (string.Compare(textBoxFFMPEGPath.Text, textBoxOutputFolder.Text) == 0)
            {
                MessageBox.Show("Input and output folder cannot be the same folder.");
                return;
            }
            if (!File.Exists(Path.Combine(textBoxFFMPEGPath.Text, "ffmpeg.exe")))
            {
                MessageBox.Show("ffmpeg.exe not found in specified folder");
                return;
            }

            GlobalFFOptions.Configure(new FFOptions { BinaryFolder = textBoxFFMPEGPath.Text, TemporaryFilesFolder = Path.GetTempPath() });

            backgroundWorker1.RunWorkerAsync(new BackgroundWorkerArguments(
               textBoxFFMPEGPath.Text,
                textBoxVideoPath.Text,
                textBoxTopRowLanguage.Text,
                textBoxBottomRowLanguage.Text,
                textBoxOutputFolder.Text,
              radioButtonExtractFiles.Checked ? BackgroundWorkerWorkMode.ExtractSubtitle
                : BackgroundWorkerWorkMode.InjectToVideo
                , checkBoxSetAsDefault.Checked
            ));
        }

        private void toolStripButtonStop_Click(object sender, EventArgs e)
        {
            if(backgroundWorker1.IsBusy)
                backgroundWorker1.CancelAsync();
        }
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorkerArguments? arguments = e.Argument as BackgroundWorkerArguments;
            if (arguments == null) return;

            var files = Directory.EnumerateFiles(arguments.VideoPath, "*.mp4", SearchOption.AllDirectories);
            int fileCount = files.Count();
            if (fileCount == 0)
                throw new FileNotFoundException("No mp4 file under specified folder");
            List<Exception> exceptions=new List<Exception>();
            int filesProcessed = 0;
                foreach (var file in files)
            {
                if (backgroundWorker1.CancellationPending) break;
                backgroundWorker1.ReportProgress(
                    (filesProcessed) * 100 / fileCount,
                    string.Format("Processing file {0} of {1} :{2}", filesProcessed + 1, fileCount, file)
                    );
                
                try
                {
                    ProcessFile(file, arguments);

                }
                catch (Exception ex)
                {
                    exceptions.Add(ex);
                }
                
                filesProcessed++;
            }
            backgroundWorker1.ReportProgress(
                   0,
                    string.Format("Processed file {0} of {1}", filesProcessed, fileCount)
                    );
            if (exceptions.Any())
            { 
                throw new AggregateException(exceptions.ToArray()); 
            }
        }
        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            if (e.UserState != null)
            {
                string? message = e.UserState as string;
                if (message != null)
                    this.toolStripStatusLabel.Text = message;
            }
            this.toolStripProgressBarStatus.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
        }
        static void ProcessFile(string file, BackgroundWorkerArguments arguments)
        {
            var relativePathToRoot = Path.GetRelativePath(arguments.VideoPath, file);
            var outputVideoFileName = Path.Combine(arguments.OutputFolder, relativePathToRoot);
            var parentFolder = Path.GetDirectoryName(outputVideoFileName);
            if (parentFolder != null)
                Directory.CreateDirectory(parentFolder);
            var tempFolder = Path.GetTempPath();
            
            var mediaInfo = FFProbe.Analyse(file);

            if (mediaInfo != null && mediaInfo.SubtitleStreams != null)
            {
                if (mediaInfo.SubtitleStreams.Count < 2)
                {
                    return;
                }
                var topRowSubtitleStream = mediaInfo.SubtitleStreams.Where(
                    s => s.Language == arguments.TopRowLanguage
                    &&s.CodecName!= "dvd_subtitle").FirstOrDefault();
                var buttonRowSubtitleStream = mediaInfo.SubtitleStreams.Where(
                    s => s.Language == arguments.BottomRowLanguage && s.CodecName != "dvd_subtitle").FirstOrDefault();
                SubtitleInfo? higherSubtitle = SubtitleInfo.FFMPEGReadSubtitleFromFile(file, topRowSubtitleStream);
                SubtitleInfo? lowerSubtitle = SubtitleInfo.FFMPEGReadSubtitleFromFile(file, buttonRowSubtitleStream);
                var mergedSubtitle = SubtitleInfo.Merge(higherSubtitle, lowerSubtitle);
                SubtitleInfo? mergedSubtitleInfo;
                if (mergedSubtitle != null)
                {
                    mergedSubtitleInfo = new SubtitleInfo(mergedSubtitle);
                    string? mergedSubtitleText;
                    if (mergedSubtitleInfo != null)
                        mergedSubtitleText = mergedSubtitleInfo.ToText();
                    switch (arguments.WorkMode)
                    {
                        case BackgroundWorkerWorkMode.ExtractSubtitle:
                            ExtractSubtitles(file, arguments, relativePathToRoot, outputVideoFileName,
                                mediaInfo, topRowSubtitleStream,
                                buttonRowSubtitleStream, mergedSubtitle, mergedSubtitleInfo);
                            break;
                        case BackgroundWorkerWorkMode.InjectToVideo:
                            List<SubtitleInfo> subtitleInfos = new List<SubtitleInfo>();
                            foreach (var subtitleStream in mediaInfo.SubtitleStreams)
                            {
                                SubtitleInfo? subtitleInfo = SubtitleInfo.FFMPEGReadSubtitleFromFile(file, subtitleStream);
                                if (subtitleInfo == null)
                                    continue;
                                subtitleInfos.Add(subtitleInfo);
                            }
                            //to avoid duplicates first process subtitles 
                            //then compare with existing subtitles
                            var tempSubtitleTargetFile = Path.Combine(tempFolder,
                    string.Format("{0}.{1}.merged.srt", Path.GetFileName(file), arguments.TopRowLanguage));
                            SubtitleInfo? subtitleInfoToBeInjected = SubtitleInfo.FFMPEGTransformSubtitle(mergedSubtitleInfo,
                                file,
                                arguments.TopRowLanguage, tempSubtitleTargetFile);
                            if (subtitleInfoToBeInjected == null)
                            {
                                break;
                            }
                            //check if already injected
                            if (subtitleInfos.Any(s => subtitleInfoToBeInjected.RawData.SequenceEqual(s.RawData)))
                                break;
                            SubtitleInfo.FFMPEGInjectToFile(file, arguments,
                                    relativePathToRoot, outputVideoFileName, tempSubtitleTargetFile, arguments.TopRowLanguage, mediaInfo);
                            break;
                        default:
                            break;
                    }
                }
                else
                    throw new FileNotFoundException(
                        string.Format("The specified file {0} does not have one of the required subtitle track in text format.",file));
            }
        }


        static void ExtractSubtitles(string file, BackgroundWorkerArguments arguments,
            string relativePathToRoot,string outputVideoFileName,
            IMediaAnalysis mediaInfo, SubtitleStream? topRowSubtitleStream, SubtitleStream? buttonRowSubtitleStream, List<MergedSubtitle>? mergedSubtitle, 
            SubtitleInfo? mergedSubtitleInfo)
        {
            foreach (var subtitleStream in mediaInfo.SubtitleStreams)
            {

                SubtitleInfo? subtitleInfo = SubtitleInfo.FFMPEGReadSubtitleFromFile(file, subtitleStream);
                if (subtitleInfo != null)
                {
                    var subtitleFileName =
                    string.Format("{0}.{1}.{2}.srt", outputVideoFileName,
                    subtitleStream.Index, subtitleStream.Language);
                    File.WriteAllText(subtitleFileName, subtitleInfo.ToText());
                }
            }

            if (mergedSubtitle != null && topRowSubtitleStream != null && buttonRowSubtitleStream != null)
            {
                var mergeSubtitleFileName =
                   string.Format("{0}.{1}.{2}_{3}.srt", outputVideoFileName,
                   mediaInfo.Format.StreamCount,
                   topRowSubtitleStream.Language,
                   buttonRowSubtitleStream.Language);
                if (mergedSubtitleInfo != null)
                    File.WriteAllText(mergeSubtitleFileName, mergedSubtitleInfo.ToText());
            }
        }


    }
}
