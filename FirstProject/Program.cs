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
        }

    }

    
}


