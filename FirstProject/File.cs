using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    interface IFile
    {
        string FileName { get; set; }
        int Size { get; set; }
        DateTime CreatedOn { get; set; }
        void Compress();
    }
}
