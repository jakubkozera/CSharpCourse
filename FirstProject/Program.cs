using System;
using System.Text;
using System.Threading.Channels;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Year of birth?");
            string userInput = Console.ReadLine();

            int yearOfBirth = int.Parse(userInput);
            bool isUserOver18 = DateTime.Now.Date.Year - yearOfBirth > 18;
            if (isUserOver18)
            {
                Console.WriteLine("hello");
            }
            else if(DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Oh well its Sunday");
            }
            else
            {
                Console.WriteLine("Access denied");
            }

            Console.WriteLine("bye");
        }
    }
}


