using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;

namespace FirstProject
{
    class Program
    {
        static List<Currency> GetCurrencies()
        {
            return new List<Currency>
            {
                new Currency("usd", "United States, Dollar", 1),
                new Currency("eur", "Euro", 0.83975),
                new Currency("gbp", "British Pound", 0.74771),
                new Currency("cad", "Canadian Dollar", 1.30724),
                new Currency("inr", "Indian Rupee", 73.04),
                new Currency("mxn", "Mexican Peso", 21.7571)
            };
        }

        static void Main(string[] args)
        {
            List<Currency> currencies = GetCurrencies();
            Console.WriteLine("Check the rate for:");
            string userInput = Console.ReadLine();

            Currency selectedCurrency = currencies.FirstOrDefault(c => c.Name == userInput);
            if (selectedCurrency == null)
            {
                Console.WriteLine($"Rate for USD to {selectedCurrency.FullName} is {selectedCurrency.Rate}");
            }
            else
            {
                Console.WriteLine("Currency not found");
            }
        }

    }
}


