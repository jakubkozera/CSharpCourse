// ReSharper disable All
using System;

namespace FirstProject
{
   
    class Program
    {
        static void Display(object obj)
        {
            Type objType = obj.GetType();
            var properties = objType.GetProperties();

            foreach (var property in properties)
            {
                var propValue = property.GetValue(obj);

                var propType = propValue.GetType();

                if (propType.IsPrimitive || propType == typeof(string))
                {
                    Console.WriteLine($"{property.Name}: {propValue}");

                }
            }
        }


        static void Main(string[] args)
        {
            Address address = new Address()
            {
                City = "Krakow",
                PostalCode = "31-556",
                Street = "Grodzka 5"
            };

            Person person = new Person()
            {
                FirstName = "John",
                LastName = "Doe",
                Address = address
            };
            Console.WriteLine("Person:");
            Display(person);
            Console.WriteLine("Address:");
            Display(address);


        }

    }
}


