// ReSharper disable All
using System;
using System.Collections.Generic;


namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var restaurants = new List<Restaurant>();

            var result = new PaginatedResult<Restaurant>();

            result.Results = restaurants;

            var users = new List<User>();

            //result.Results = users; // compile error

            //var stringRepository = new Repository<string>();

            //stringRepository.AddElement("some value");

            //string firstElement = stringRepository.GetElement(0);

            var user2Repository = new Repository<User>();


            var userRepository = new Repository<string, User>();

            userRepository.AddElement("Bill", new User() { Name = "Bill"});

            User bill = userRepository.GetElement("Bill");


            int[] intArray = new []{ 1, 3, 5};

            Utils.Swap(ref intArray[0], ref intArray[2]);


            Console.WriteLine(string.Join(" ", intArray));


        }

    }

    
}


