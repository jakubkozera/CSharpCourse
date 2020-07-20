using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class PowerPointFile : File
    {
        public override void Compress()
        {
            Console.WriteLine("Compressing PowerPointFile");
        }
        public void Present()
        {
            Console.WriteLine($"{FileName} presenting..");
        }
    }
}
