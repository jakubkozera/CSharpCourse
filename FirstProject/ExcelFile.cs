using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class ExcelFile : File
    {


        public void GenerateReport()
        {
            string prop = ProtectedProp;
            Console.WriteLine($"{FileName} report..");
        }
    }
}
