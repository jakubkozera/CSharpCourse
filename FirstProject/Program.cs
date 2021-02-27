using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using JsonConverter = Newtonsoft.Json.JsonConverter;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerSerialized = File.ReadAllText(@"D:\JSON\playerSerialized.json");
            Player player = JsonConvert.DeserializeObject<Player>(playerSerialized);

            Console.WriteLine(player.Name);

            //var player = new Player()
            //{
            //    Name = "Mario",
            //    Level = 1,
            //    HealthPoints = 100,
            //    Statistics = new List<Statistic>()
            //    {
            //        new Statistic()
            //        {
            //            Name = "Strength",
            //            Points = 10
            //        },
            //        new Statistic()
            //        {
            //            Name = "Intelligence",
            //            Points = 10
            //        }
            //    }
            //};

            ////..
            //player.Level++;

            //string playerSerialized = JsonConvert.SerializeObject(player);

            //File.WriteAllText(@"D:\JSON\playerSerialized.json", playerSerialized);

        }
    }
}

