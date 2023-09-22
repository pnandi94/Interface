using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class BejaroTippelo : GepiJatekos
    {
        private int aktualis;

        public override int KovetkezoTipp()
        {
            return aktualis++;
        }

        public new void JatekIndul(int alsoHatar, int felsoHatar)
        {
            base.JatekIndul(alsoHatar, felsoHatar);
            aktualis = alsoHatar;
        }
    }
}
