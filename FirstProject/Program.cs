using System;
using System.Text;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Mazda" };

            Console.WriteLine(cars[0]);
            cars[2] = "Tesla";

            int carsCount = cars.Length; // 3

            string lastElement = cars[cars.Length - 1];
            Console.WriteLine(lastElement);

        }
    }
}


