#pragma warning disable 219
using System;
using System.Globalization;
using System.Text;
using System.Threading.Channels;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Mazda" };


            try
            {
                Console.WriteLine("Inside try - 1");
                cars[4] = "Tesla"; // throws System.IndexOutOfRangeException
                Console.WriteLine("Inside try - 2");

            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Handling IndexOutOfRangeException exception");
            }
            catch (Exception e)
            {
                Console.WriteLine("Handling any exception");
            }
            finally
            {
                Console.WriteLine("Cleanup");
            }
            Console.WriteLine("Outside of try-catch");
        }
    }
}


