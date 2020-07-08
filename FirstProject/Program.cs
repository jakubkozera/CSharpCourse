#pragma warning disable 219
using System;
using System.Text;
using System.Threading.Channels;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int? favoriteNumber = 23;

            Console.WriteLine("Favorite number: " + (favoriteNumber.HasValue ? favoriteNumber.Value.ToString() : ""));
        }
    }
}


