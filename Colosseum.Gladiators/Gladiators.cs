using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colosseum.Gladiators
{
    public class Gladiators
    {
        //Creates Custom Gladiator
        public static GladiatorStats CreateGladitor(string name, int hp, int atk, int def, int ctd)
        {
            var gladiator = new GladiatorStats()
            {
                Name = name,
                Hp = hp,
                Atk = atk,
                Def = def,
                Ctd = ctd
            };

            return gladiator;
        }

        //This Acts as a basic DB
        public static List<GladiatorStats> BaseGladiators()
        {
            var myrmillonis = new GladiatorStats()
            {
                Name = "Retarius",
                Atk = 90,
                Hp = 250,
                Def = 50,
                Ctd = 18,
                Key = ConsoleKey.R
            };

            var retarius = new GladiatorStats()
            {
                Name = "Myrmillionis",
                Hp = 300,
                Atk = 80,
                Def = 30,
                Ctd = 90,
                Key = ConsoleKey.M
            };

            var gladiators = new List<GladiatorStats>();

            gladiators.Add(myrmillonis);
            gladiators.Add(retarius);

            return gladiators;
        }
    }
}