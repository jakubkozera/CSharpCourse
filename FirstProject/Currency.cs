using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Currency
    {
        public Currency(string name, string fullName, double rate)
        {
            Name = name;
            FullName = fullName;
            Rate = rate;
        }
        public string Name { get; set; }
        public string FullName { get; set; }
        public double Rate { get; set; }
    }
}
