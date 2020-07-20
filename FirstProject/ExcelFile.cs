using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class ExcelFile : File
    {

        public override void Compress()
        {
            Console.WriteLine("Compressing ExcelFile");
        }
        public void GenerateReport()
        {
            string prop = ProtectedProp;
            Console.WriteLine($"{FileName} report..");
        }
    }
}
