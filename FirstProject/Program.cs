using System;
using System.Text;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string message1;
            message1 = "some value";
            Console.WriteLine(message1);

            string message2 = null;
            Console.WriteLine(message2);
            string message3 = string.Empty;
            string text = "He said \"Hi\"";
            Console.WriteLine(text);
            string windowLocation = "c:\\windows";
            Console.WriteLine(windowLocation);
            string fontsFolder = @"c:\windows\fonts";
            Console.WriteLine(fontsFolder);
            string concatenated = string.Concat(text, " to ", "me");
            string concatenated2 = text + " to " + "me";
            Console.WriteLine(concatenated);
            Console.WriteLine(concatenated2);

            string interpolated = $"{text} to me";
            Console.WriteLine(interpolated);
            StringBuilder sb = new StringBuilder("This");
            sb.Append("is");
            sb.Append("a");
            sb.Append("long");
            sb.Append("text");

            string result = sb.ToString();
            Console.WriteLine(result);
        }
    }
}
