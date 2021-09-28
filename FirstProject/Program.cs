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


            var joinedData = people.GroupJoin(addresses,
                p => p.Id,
                a => a.PersonId,
                (person, addresses) => new { person.Name, Addresses = addresses });

            foreach (var element in joinedData)
            {
                Console.WriteLine($"Name : {element.Name}");
                foreach (var address in element.Addresses)
                {
                    Console.WriteLine($"\t City: { address.City}, street: {address.Street}");
                }

            }

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


