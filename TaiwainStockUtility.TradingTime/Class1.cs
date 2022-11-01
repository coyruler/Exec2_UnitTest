using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiwainStockUtility.TradingTime
{
    public class TaiwainStockUtilityCl
    {
        DateTime starttime = new DateTime(2020, 1, 1, 9, 0, 0);
        DateTime endtime = new DateTime(2020, 1, 1, 13, 30, 0);

        DateTime input;


        public OpenTime Input(DateTime input)
        {
            if (input.DayOfWeek == DayOfWeek.Saturday || input.DayOfWeek == DayOfWeek.Sunday)
            {
                return OpenTime.Close();
            }
            if (input.TimeOfDay < starttime.TimeOfDay || input.TimeOfDay > endtime.TimeOfDay)
            {
                return OpenTime.Close();
            }
            else
            {
                return OpenTime.Open();
            }
        }
        public class OpenTime
        {
            public static OpenTime Open()
            {
                return new OpenTime { IsOpen = true };
            }
            public static OpenTime Close()
            {
                return new OpenTime { IsOpen = false };
            }
            public bool IsOpen { get; set; }

        }
    }
}
