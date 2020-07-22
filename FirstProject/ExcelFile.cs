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
            Console.WriteLine($"{FileName} report..");
        }
    }
}
