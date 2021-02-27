using System.Collections.Generic;

namespace FirstProject
{
    public class Player
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int HealthPoints { get; set; }
        public List<Statistic> Statistics { get; set; }
    }
}
