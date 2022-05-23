using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.MeduimChallenges.Intervals
{
    public class Interval
    {
        public int start, end;
        Interval(int start, int end)
        {
            this.start = start;
            this.end = end;
        }
        class minNumOfMeetingRoom
        {
            public static int MinMeetingRooms(List<Interval> intervals)
            {
                int count = 1;
                if (intervals.Count == 0) return 0;
                if (intervals.Count == 1) return count;
                intervals = intervals.OrderBy(x => x.start).ToList();
                for (int i = 0; i < intervals.Count - 1; i++)
                {
                    if (intervals[i].end > intervals[i + 1].start)
                        count++;
                }
                return count;
            }

            
        }
    }
}
