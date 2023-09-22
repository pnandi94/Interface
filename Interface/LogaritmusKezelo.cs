using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class LogaritmikusKereso : GepiJatekos, IOkosTippelo
    {
        private int aktualis;

        public override int KovetkezoTipp()
        {
            aktualis = (alsoHatar + felsoHatar) / 2;
            return aktualis;
        }

        public void Kisebb()
        {
            felsoHatar = aktualis - 1;
        }

        public void Nagyobb()
        {
            alsoHatar = aktualis + 1;
        }
    }
}
