// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Linq;


namespace FirstProject
{
    class Program
    {
        public delegate void Display(string value);

        public delegate bool GenericPredicate<T>(T value);

        static void Main(string[] args)
        {

            Display display = (string value) => Console.Write(value + ", ");

            display("Test");

            var numbers = new int[] {10, 30, 50};
            //DisplayNumbers(number, display);
            var count = Count(numbers, (int value) => value > 35);
            Console.WriteLine(count);

            var strings = new string[] {"Generic", "Delegate", "test"};
            var countString = Count(strings, value => value.Length > 4);
            Console.WriteLine($"countString {countString}");
        }

        static void DisplayNumbers(IEnumerable<int> numbers, Display display)
        {
            foreach (int number in numbers)
            {
                display(number.ToString());
            }
        }

        static int Count<T>(IEnumerable<T> elements, Predicate<T> predicate)
        {
            int count = 0;
            foreach (T element in elements)
            {
                if (predicate(element))
                {
                    count++;
                }
            }

            return count;
        }

    }

    
}


