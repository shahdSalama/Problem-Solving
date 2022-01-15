using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Easy
{
    class Meetings
    {
		public class Interval
		{
			public DateTime startTime;
			public DateTime endTime;

		}

		class Solution
		{

			public static bool CanAttendAllMeetings(List<Interval> meetings)
			{

				if (meetings == null || meetings.Count == 0)
				{
					return false;
				}

				// sort meetings according to the start time
				meetings = meetings.OrderBy(x => x.startTime).ToList();

				for (int i = 0; i < meetings.Count - 1; i++)
				{
					// overlapping meetings
					if (meetings[i].endTime > meetings[i + 1].startTime)
					{
						return false;
					}

				}
				// did not encounter overlapping meetings and all meetings finish before next meeting's start time
				return true;
			}

		}
	}
}
