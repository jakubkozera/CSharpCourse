using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class PowerPointFile : IFile
    {
        public string FileName { get; set; }
        public int Size { get; set; }
        public DateTime CreatedOn { get; set; }
        public void Compress()
        {
            Console.WriteLine("Compressing PowerPointFile");
        }
        public void Present()
        {
            Console.WriteLine($"{FileName} presenting..");
        }
    }
}
