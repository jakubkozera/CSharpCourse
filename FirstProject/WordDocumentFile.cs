using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FirstProject
{
    class WordDocumentFile : IFile
    {
        public string FileName { get; set; }
        public int Size { get; set; }
        public DateTime CreatedOn { get; set; }
        public void Compress()
        {
            Console.WriteLine("Compressing WordDocumentFile");
        }
        public void Print()
        {
            Console.WriteLine($"{FileName} printing..");
        }
    }
}
