using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colosseum.Data
{
    public class GladiatorTemplate
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Ap { get; set; }
        public int Def { get; set; }
        public int Ctd { get; set; }
        public ConsoleKey Key { get; set; }
        public string Description { get; set; }

    }
}