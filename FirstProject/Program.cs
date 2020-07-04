using System;
using System.Text;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Mazda" };

            int i = 0;
            while (i < cars.Length)
            {
                Console.WriteLine(cars[i]);
                if (cars[i] == "BMW")
                {
                    Console.WriteLine("Bye");
                    break;
                }
                i++;
            }

            Console.WriteLine("********");

            for (int j = 0; j < cars.Length; j++)
            {
                Console.WriteLine(cars[j]);
                if (cars[j] == "BMW")
                {
                    Console.WriteLine("Bye");
                    break;
                }
            }
        }
    }
}


