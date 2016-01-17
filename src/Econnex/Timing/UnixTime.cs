using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Econnex.Timing
{
    public class UnixTime
    {
        public static DateTime ConvertFromTicks(long ticks)
        {
            var date = new DateTime(1970, 1, 1);
            date = date.AddSeconds(ticks);

            return date;
        }

        public static long UnixTicks(DateTime dt)
        {
            var epoc = new DateTime(1970, 1, 1);
            var delta = dt - epoc;
            if (delta.TotalSeconds < 0)
            {
                throw new ArgumentOutOfRangeException(
                    "Unix epoc starts January 1st, 1970");
            }
            return (long)delta.TotalSeconds;
        }
    }
}
