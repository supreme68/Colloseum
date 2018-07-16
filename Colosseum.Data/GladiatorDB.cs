using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colosseum.Data
{
    class GladiatorDB
    {
        //This Acts as a basic DB
        public static List<GladiatorTemplate> AllGladiators()
        {
            var retarius = new GladiatorTemplate()
            {
                Name = "Retarius",
                Ap = 80,
                Hp = 250,
                Def = 20,
                Ctd = 50,
                Key = ConsoleKey.R,
                Description = "This warrior plays the role of a fisherman armed with net, trident and knife" +
                " Rarely dressed in armor he uses his mobility and speed to catch his prey in his net and kill him with his trident"
            };

            var myrmillonis = new GladiatorTemplate()
            {
                Name = "Myrmillionis",
                Ap = 70,
                Hp = 300,
                Def = 30,
                Ctd = 40,
                Key = ConsoleKey.M,
                Description = "This gladiator has a lot of similarities with Retarius." +
                " Armed with scutum(big square shield) and gladius." +
                " His armor is often incrustated with fish like images and fish parts"
            };

            var thraex = new GladiatorTemplate()
            {
                Name = "Thraex",
                Ap = 75,
                Hp = 300,
                Def = 20,
                Ctd = 70,
                Key = ConsoleKey.T,
                Description = "Gladiator armed like a thracian warrior. He fight with a small shield and sword"
            };

            var gladiators = new List<GladiatorTemplate>();

            gladiators.Add(myrmillonis);
            gladiators.Add(retarius);
            gladiators.Add(thraex);

            return gladiators;
        }

    }
}
