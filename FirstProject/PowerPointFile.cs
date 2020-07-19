using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class PowerPointFile : File
    {

        public void Present()
        {
            Console.WriteLine($"{FileName} presenting..");
        }
    }
}
