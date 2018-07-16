using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colosseum.Data;

namespace Colosseum.Start
{
    class BattleEngine
    {
        //Begins Fight Simulation
        public static void FightStart(GladiatorTemplate firstGladiator, GladiatorTemplate secondGladiator)
        {
            int firstGladiatorDamge = firstGladiator.Ap - secondGladiator.Def;
            int secondGladiatorDamge = secondGladiator.Ap - firstGladiator.Def;

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

        //Gets Random Number Between 1 and 100
        private static int GetRandomNumber()
        {
            Random random = new Random();

            return random.Next(0, 100);
        }
    }
}
