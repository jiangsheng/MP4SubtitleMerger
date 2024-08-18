using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP4SubtitleMerger
{
    public class MergedSubtitle
    {
        public MergedSubtitle(TimeSpan from, TimeSpan to, List<MergedSubtitleLine> lines)
        {
            From = from;
            To = to;
            Lines = lines;
        }

        public TimeSpan From { get; set; }
        public TimeSpan To { get; set; }
        public List<MergedSubtitleLine> Lines { get; set; }
    }
}
