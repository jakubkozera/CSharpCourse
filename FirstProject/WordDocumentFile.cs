using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FirstProject
{
    class WordDocumentFile : File
    {
        public override void Compress()
        {
            Console.WriteLine("Compressing WordDocumentFile");
        }
        public void Print()
        {
            Console.WriteLine($"{FileName} printing..");
        }
    }
}
