using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class SomeClass : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Disposing someclass");
        }

        public void Say(string input)
        {
            Console.WriteLine(input);
        }
    }
}
