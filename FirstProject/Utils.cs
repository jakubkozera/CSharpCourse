using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public static class Utils
    {
        public static bool IsDateBetween(DateTime date, DateTime from, DateTime to)
        {
            return date > from && date < to;
        }

        public static bool IsBetween(this DateTime date, DateTime from, DateTime to)
        {
            return date > from && date < to;
        }

        public static int Squared(this int value)
        {
            return value * value;
        }
    }
}
