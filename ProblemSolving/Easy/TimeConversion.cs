using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class TimeConversion
    {
        public static string timeConversion(string s)
        {
            char[] timeasChar = s.ToArray();
            string AMPM = string.Concat(timeasChar[timeasChar.Count() - 2], timeasChar[timeasChar.Count() - 1]);
            string timeWithoutAMPM = s.Remove(8);
            string[] HoursMinsSecs = timeWithoutAMPM.Split(':');

            double hours = Convert.ToDouble(HoursMinsSecs[0]);
            double mins = Convert.ToDouble(HoursMinsSecs[1]);
            double secs = Convert.ToDouble(HoursMinsSecs[2]);


            if (hours == 12 && AMPM == "AM")
                hours = 0;

            DateTime d = new DateTime();

            d = d.AddMinutes(mins);
            d = d.AddSeconds(secs);

            if (AMPM == "PM" && hours != 12) hours += 12;

            d = d.AddHours(hours);

            #region
            Console.WriteLine(hours);
            Console.WriteLine(mins);
            Console.WriteLine(secs);
            Console.WriteLine(AMPM);
            #endregion

            return d.ToString("HH:mm:ss");
        }
        static string timeConversionVersion2(string s)
        {
            DateTime d = DateTime.Parse(s);
            return d.ToString("HH:mm:ss");
        }

    }
}
