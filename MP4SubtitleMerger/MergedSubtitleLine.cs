namespace MP4SubtitleMerger
{
    public class MergedSubtitleLine
    {
        public MergedSubtitleLine(string text, SubtitleSource source)
        {
            Text = text;
            Source = source;
        }

        public String  Text { get; set; }
        public SubtitleSource Source { get; set; }
    }
}
