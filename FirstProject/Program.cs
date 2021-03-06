using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //kebab case:
            //some-variable-name

            //camel case:
            //someVariableName

            Console.WriteLine("Insert camel cased variable name");
            string camelCased = Console.ReadLine();

            Console.WriteLine(CamelToKebabCase(camelCased));

        }

        static string CamelToKebabCase(string input)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char currentChar in input)
            {
                if (char.IsUpper(currentChar))
                {
                    sb.Append("-");
                    sb.Append(char.ToLower(currentChar));
                }
                else
                {
                    sb.Append(currentChar);
                }
            }

            return sb.ToString();
        }
        static string KebabToCamelCase(string input)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (currentChar != '-')
                {
                    sb.Append(currentChar);
                }
                else
                {
                    char nextChar = input[i + 1];
                    sb.Append(char.ToUpper(nextChar));
                    i++;
                }
            }

            return sb.ToString();

        }
    }
}


