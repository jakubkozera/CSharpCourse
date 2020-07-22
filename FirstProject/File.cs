using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    abstract class File
    {
        public string FileName { get; set; }
        public int Size { get; set; }
        public DateTime CreatedOn { get; set; }
        public abstract void Compress();
    }
}
