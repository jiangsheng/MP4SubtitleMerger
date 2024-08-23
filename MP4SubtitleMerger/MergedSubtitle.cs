using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

        //return true if difference found, otherwise false
        public static bool CompareLines(MergedSubtitle left, MergedSubtitle right) 
        {
            if (left.Lines.Count!=right.Lines.Count) return true;
            for (int j = 0; j < left.Lines.Count; j++)
            {
                if (left.Lines[j].Source !=
                right.Lines[j].Source)
                {
                    return true;
                }
                if (string.Compare(left.Lines[j].Text,
                    right.Lines[j].Text,
                    StringComparison.Ordinal) != 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
