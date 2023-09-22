using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class VeletlenTippelo : GepiJatekos
    {
        private Random random;

        public VeletlenTippelo()
        {
            random = new Random();
        }

        public override int KovetkezoTipp()
        {
            return random.Next(alsoHatar, felsoHatar + 1);
        }
    }
}
