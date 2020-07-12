using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bill = new Person();

            bill.FirstName = "Bill";

            Console.WriteLine($"{bill.FirstName} {bill.DateOfBirth}");

        }
    }
}


