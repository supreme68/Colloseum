using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Colloseum.Gladiators
{
    public class MyrmillonisGladiator : GladiatorBase
    {
        public override int Damage(int dragonAtk, int knightDef)
        {
            int damage = dragonAtk - knightDef;

            if (GetRandomNumber() > damage)
            {
                return damage;
            }
            else
            {
                return 1000;
            }
        }

        public override bool ChanceToHit(int dragonCtd)
        {
            int ctd = 100 - dragonCtd;

            if (GetRandomNumber() > ctd)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
