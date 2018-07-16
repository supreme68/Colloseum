using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colosseum.Data
{
    public class GladiatorData
    {
        //Selects Gladiator By Key Input
        public static GladiatorTemplate SelectGladiatorByKeyInput(ConsoleKey key)
        {
            var gladiatorDb = GladiatorDB.AllGladiators();

            var gladiator = (from g in gladiatorDb
                             where g.Key == key
                             select g).FirstOrDefault();

            return gladiator;
        }

        public static List<GladiatorTemplate> SelectAllGladiators()
        {
            var gladiatorDb = GladiatorDB.AllGladiators();

            var gladiators = (from g in gladiatorDb
                              select g).ToList();

            return gladiators;
        }

        //Creates new Gladiator
        public static GladiatorTemplate CreateGladiator(string name, int hp, int ap, int def, int ctd)
        {
            var gladiatorInstance = new GladiatorTemplate
            {
                Name = name,
                Hp = hp,
                Ap = ap,
                Def = def,
                Ctd = ctd
            };

            return gladiatorInstance;
        }
    }
}