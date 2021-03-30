// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Linq;


namespace FirstProject
{
    class Program
    {
        public static IEnumerable<int> GetData()
        {
            Console.WriteLine("Get data start");

            var result = new List<int>();
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine($"Get data element: {i}");
                result.Add(i);
            }

            Console.WriteLine("Get data end");

            return result;
        }
        public static IEnumerable<int> GetYieldedData()
        {
            Console.WriteLine("GetYieldedData start");

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"GetYieldedData element: {i}");
                yield return i;
                if (i % 3 == 0)
                {
                    yield break;
                }
            }

            Console.WriteLine("GetYieldedData stop");

        }


        static void Main(string[] args)
        {
            var data = GetYieldedData();
            foreach (int element in data)
            {
                Console.WriteLine($"main element: {element}");
                if (element > 5)
                {
                    break;
                }
            }
        }

    }

    
}


