using FirstProject;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = LoadPeople();
            var addresses = LoadAddresses();


            var joinedData = people.Join(addresses,
                p => p.Id,
                a => a.PersonId,
                (person, address) => new { person.Name, address.Street, address.City });

            foreach (var element in joinedData)
            {
                Console.WriteLine($"Name : {element.Name}, address: {element.City}, {element.Street}" );
            }

            //foreach (var person in people)
            //{
            //    var address = addresses.FirstOrDefault(a => a.PersonId == person.Id);
            //    if(address != null)
            //    {
            //        Console.WriteLine($"Name: {person.Name}, adress: {address.City} {address.Street}");

            //    }
            //}



            Console.WriteLine();
        }

        private static List<Person> LoadPeople()
        {
            var currentDir = Directory.GetCurrentDirectory();
            var jsonFullPath = Path.GetRelativePath(currentDir, "Person/People.json");

            var json = File.ReadAllText(jsonFullPath);

            return JsonConvert.DeserializeObject<List<Person>>(json);
        }
        private static List<Address> LoadAddresses()
        {
            var currentDir = Directory.GetCurrentDirectory();
            var jsonFullPath = Path.GetRelativePath(currentDir, "Person/Addresses.json");

            var json = File.ReadAllText(jsonFullPath);

            return JsonConvert.DeserializeObject<List<Address>>(json);
        }
    }

    
}


