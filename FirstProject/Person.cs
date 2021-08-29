using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Person
    {
        [DisplayProperty("First Name")]
        public string FirstName { get; set; }

        [DisplayProperty("Last Name")]
        public string LastName { get; set; }
        public Address Address { get; set; }

    }
}
