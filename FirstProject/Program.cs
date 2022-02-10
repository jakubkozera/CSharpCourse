using System;
using System.Text.RegularExpressions;

namespace FirstProject
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Regex regex = new Regex(@"^([a-z0-9]+)\.?([a-z0-9]+)@([a-z]+)\.[a-z]{2,3}$");
            string email = "testm.test2@gmail.com";

            bool isMatch = regex.IsMatch(email);
            Console.WriteLine(isMatch);
        }
    }
}