using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class VeletlenTippelo : GepiJatekos
    {
        private Random random = new Random();

        public override int KovetkezoTipp()
        {
            return random.Next(alsoHatar, felsoHatar + 1);
        }
    }
}
