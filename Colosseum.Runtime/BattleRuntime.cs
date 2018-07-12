using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colosseum.Gladiators;

namespace Colosseum.Runtime
{
    public class BattleRuntime
    {
        //Selects Gladiator By Key Input
        public static GladiatorStats SelectGladiatorByKeyInput(ConsoleKey key)
        {
            var gladiatorBase = Gladiators.Gladiators.BaseGladiators();

            var gladiator = (from g in gladiatorBase
                             where g.Key == key
                             select g).FirstOrDefault();
            
            
            return gladiator;
        }

        //Begins Fight Simulation
        public static void BeginFight(GladiatorStats firstGladiator, GladiatorStats secondGladiator)
        {
            int firstGladiatorDamge = firstGladiator.Atk - secondGladiator.Def;
            int firstGladiatorHp = firstGladiator.Hp;

            int secondGladiatorHp = secondGladiator.Hp;
            int secondGladiatorDamge = secondGladiator.Atk - firstGladiator.Def;

            while (firstGladiatorHp > 0)
            {
                secondGladiatorHp -= firstGladiatorDamge;

                if (secondGladiatorHp == 0)
                {
                    break;
                }

                while (secondGladiatorHp > 0)
                {
                    firstGladiatorHp -= secondGladiatorDamge;
                    break;
                }
            }

            if (firstGladiatorHp == 0)
            {
                Console.WriteLine(secondGladiator.Name + " Wins");
            }
            else
            {
                Console.WriteLine(firstGladiator.Name + " Wins");
            }
        }
    }
}