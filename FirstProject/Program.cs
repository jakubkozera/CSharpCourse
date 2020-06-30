using System;
using System.Text;
using System.Threading.Channels;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("It's Monday ;(");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("The last day of the work week.");
                    break;
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:
                    Console.WriteLine("The weekend!");
                    break;
                default:
                    Console.WriteLine("The middle of the work week.");
                    break;

            }
        }
    }
}


