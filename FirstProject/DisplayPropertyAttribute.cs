using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DisplayPropertyAttribute : Attribute
    {
        public string DisplayName { get; set; }

        public DisplayPropertyAttribute(string displayName)
        {
            DisplayName = displayName;
        }
    }
}
