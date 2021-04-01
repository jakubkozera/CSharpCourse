// ReSharper disable All
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = "D:/file.txt";
            var fileContent = File.ReadAllLines(filePath);


            using (var someClass = new SomeClass())
            {
                someClass.Say("Hi");
            }

            using (var readFileStream = new FileStream(filePath, FileMode.Open))
            {
                //readFileStream.Read();

            }




            //...

            var writeFileStream = new FileStream(filePath, FileMode.Open);
            try
            {
                //writeFileStream.Write();

            }
            finally
            {
                ((IDisposable)writeFileStream).Dispose();
            }

            writeFileStream.Close();

        }

    }

    
}


