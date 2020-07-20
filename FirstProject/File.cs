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
        protected string ProtectedProp { get; set; }
        private string PrivateProp { get; set; }

        public abstract void Compress();
    }
}
