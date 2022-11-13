using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Easy
{
    class addone
    {

        private static DateTime GetThisFriday()
        {
            DateTime today = DateTime.Today;
            int daysUntilFriday = ((int)DayOfWeek.Friday - (int)today.DayOfWeek + 7) % 7;
            DateTime nextFriday = today.AddDays(daysUntilFriday+1).AddTicks(-1);
            return nextFriday;
        }

      
           
    }
}
