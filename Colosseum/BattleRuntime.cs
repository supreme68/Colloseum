using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colosseum.Data;

namespace Colosseum
{
    public class BattleRuntime
    {
        //Selects Gladiator By Key Input
        //public static GladiatorStats SelectGladiatorByKeyInput(ConsoleKey key)
        //{
        //    var gladiatorBase = Gladiators.GladiatorData.BaseGladiators();

        //    var gladiator = (from g in gladiatorBase
        //                     where g.Key == key
        //                     select g).FirstOrDefault();

        //    return gladiator;
        //}

        //Begins Fight Simulation
        public static void BeginFight(GladiatorTemplate firstGladiator, GladiatorTemplate secondGladiator)
        {
            int firstGladiatorDamge = firstGladiator.Atk - secondGladiator.Def;
            int secondGladiatorDamge = secondGladiator.Atk - firstGladiator.Def;

            while (firstGladiator.Hp > 0 && secondGladiator.Hp > 0)
            {
                if (secondGladiator.Ctd < GetRandomNumber())
                {
                    secondGladiator.Hp -= firstGladiatorDamge;
                }

                if (firstGladiator.Ctd < GetRandomNumber())
                {
                    firstGladiator.Hp -= secondGladiatorDamge;
                }
            }

            if (firstGladiator.Hp == 0)
            {
                Console.WriteLine(secondGladiator.Name + " Wins");
            }
            else
            {
                Console.WriteLine(firstGladiator.Name + " Wins");
            }
        }

        public static int GetRandomNumber()
        {
            Random random = new Random();

            return random.Next(0, 100);
        }
    }
}