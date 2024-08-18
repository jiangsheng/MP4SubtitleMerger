namespace MP4SubtitleMerger
{
    public class Subtitle
    {
        public Subtitle(TimeSpan from, TimeSpan to, List<string> lines)
        {
            From = from;To = to;Lines = lines;
        }

        public TimeSpan From{ get; set; }
        public TimeSpan To{ get; set; }
        public List<string> Lines { get; set; }
    }
}
