using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colloseum.Gladiators
{
    public class RetariusGladiator : GladiatorBase
    {
        public override int Damage(int knightAtk, int dragonDef)
        {
            int baseDamage = knightAtk - dragonDef;

            return baseDamage;

            //if (GetRandomNumber() > 33)
            //{
            //    int SpecialDamage = baseDamage * 3;

            //    return baseDamage;
            //}
        }

        public override bool ChanceToHit(int knightCtd)
        {
            int ctd = 100 - knightCtd;

            if (GetRandomNumber() > ctd)
            {
                return true;
            }

            return false;
        }
    }
}
