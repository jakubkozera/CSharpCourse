using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
// ReSharper disable UseFormatSpecifierInInterpolation

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime before = now.Subtract(new TimeSpan(7, 0, 0, 0));
            DateTime after = now.AddDays(7);

            bool isDateBetween = Utils.IsDateBetween(now, before, after);

            bool isDateBetween2 = now.IsBetween(before, after);

            int value = 2;
            value.Squared();

        }

    }
}


