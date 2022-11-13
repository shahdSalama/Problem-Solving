using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Intervals
{
    public class MyCalendar
    {

        List<(int, int)> events;

        public MyCalendar()
        {

            events = new List<(int, int)>();

        }

        public bool Book(int start, int end)
        {
            int l = 0;
            int r = events.Count - 1;
            int mid = 0;
            if (l > r)
            {
                events.Add((start, end));
                return true;
            }

            while (l <= r)
            {
                mid = (l + r) / 2;
                if ((events[mid].Item1 <= start && events[mid].Item2 > start) || (events[mid].Item1 < end && events[mid].Item2 > end) || start <= events[mid].Item1 && end <= events[mid].Item2) return false;
                if (start >= events[mid].Item2 && (mid + 1 == events.Count || start < events[mid + 1].Item1))
                {
                    events.Insert(mid + 1, (start, end));
                    return true;
                }
                else if (start < events[mid].Item1) r = mid - 1;
                else if (start > events[mid].Item1) l = mid + 1;
            }
            events.Insert(0, (start, end));
            return true;
        }
        //["MyCalendar","book","book","book","book","book","book","book","book","book","book"]
        //   [[],[47,50],[33,41],[39,45],
        //   [33,42],[25,32],[26,35],
        //   [19,25],[3,8],[8,13],[18,27]]
        //public static void Main(string[] args)
        //{
        //    var c = new MyCalendar();

        //    c.Book(47, 50);
        //    c.Book(33, 41);
        //    c.Book(39, 45);

        //    c.Book(33, 42);
        //    c.Book(25, 32);
        //    c.Book(26, 35);

        //    c.Book(19, 25);
        //    c.Book(3, 8);
        //    c.Book(8, 13);

        //    c.Book(18, 27);
        //}
    }

}
