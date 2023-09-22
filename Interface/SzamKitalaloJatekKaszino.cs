using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class SzamKitalaloJatekKaszino : SzamKitalaloJatek, IStatisztikatSzolgaltat
    {
        private int kaszinoNyert;
        private int kaszinoVeszitett;
        private int korokSzama;

        public int HanyszorNyert => kaszinoNyert;
        public int HanyszorVesztett => kaszinoVeszitett;

        public SzamKitalaloJatekKaszino(int alsoHatar, int felsoHatar, int korokSzama)
            : base(alsoHatar, felsoHatar)
        {
            this.kaszinoNyert = 0;
            this.kaszinoVeszitett = 0;
            this.korokSzama = korokSzama;
        }

        public new void Jatek()
        {
            int kor = 0;
            while (kor < korokSzama)
            {
                base.Jatek();
                if (VersenyzoNyert())
                {
                    kaszinoVeszitett++;
                    break;
                }
                kor++;
            }

            if (kor == korokSzama)
            {
                kaszinoNyert++;
            }
        }

        private bool VersenyzoNyert()
        {
            foreach (var versenyzo in versenyzok)
            {
                if (versenyzo is IJatekos && ((IJatekos)versenyzo).NyertDB > 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
