using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class BejaroTippelo : GepiJatekos
    {
        private int aktualis;

        public BejaroTippelo()
        {
            aktualis = 10;
        }

        public override int KovetkezoTipp()
        {
            aktualis++;
            if (aktualis > felsoHatar)
            {
                aktualis = alsoHatar;
            }
            return aktualis;
        }
    }
}
