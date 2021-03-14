using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class GoogleApp
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public float Rating { get; set; }
        public int Reviews { get; set; }
        public string Size { get; set; }
        public string Installs { get; set; }
        public Type Type { get; set; }
        public string Price { get; set; }
        public string ContentRating { get; set; }
        public List<string> Genres { get; set; }
        public DateTime LastUpdated { get; set; }

        public override string ToString()
        {
            return $"{(Name.Length > 25 ? Name.Substring(0, 25) + "..." : Name),-28} | " +
            $"{Category,-20} | " +
            $"{Rating,-3} | " +
            $"{Reviews,-10} | " +
            $"{Type,-4} | " +
            $"{Price,-7} | " +
            $"{LastUpdated.ToShortDateString(),-10} | " +
            $"{string.Join(", ", Genres)}";
        }
    }
}
