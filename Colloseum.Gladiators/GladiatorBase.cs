using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colloseum.Gladiators
{
    public abstract class GladiatorBase
    {
        public abstract int Damage(int atk, int def);

        public abstract bool ChanceToHit(int ctd);

        public int GetRandomNumber()
        {
            Random random = new Random();

            return random.Next(0, 100);
        }
    }
}
