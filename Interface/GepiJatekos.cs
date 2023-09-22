using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public abstract class GepiJatekos : ITippelo, IStatisztikatSzolgaltat
    {
        protected int alsoHatar;
        protected int felsoHatar;
        protected int nyertDB;
        protected int veszitettDB;

        public int HanyszorNyert { get; private set; }
        public int HanyszorVesztett { get; private set; }

        public GepiJatekos()
        {
            nyertDB = 0;
            veszitettDB = 0;
        }

        public void Nyert()
        {
            HanyszorNyert++;
            nyertDB++;
        }

        public void Veszitett()
        {
            HanyszorVesztett++;
            veszitettDB++;
        }

        public abstract int KovetkezoTipp();
        public void JatekIndul(int alsoHatar, int felsoHatar)
        {
            this.alsoHatar = alsoHatar;
            this.felsoHatar = felsoHatar;
        }

        public int NyertDB
        {
            get { return nyertDB; }
        }

        public int VeszitettDB
        {
            get { return veszitettDB; }
        }
    }
}
