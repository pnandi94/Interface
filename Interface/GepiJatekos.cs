using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public abstract class GepiJatekos : ITippelo
    {
        protected int alsoHatar;
        protected int felsoHatar;
        protected int nyertDB;
        protected int veszitettDB;

        public GepiJatekos()
        {
            nyertDB = 0;
            veszitettDB = 0;
        }

        public void JatekIndul(int alsoHatar, int felsoHatar)
        {
            this.alsoHatar = alsoHatar;
            this.felsoHatar = felsoHatar;
        }

        public void Nyert()
        {
            nyertDB++;
        }

        public void Veszitett()
        {
            veszitettDB++;
        }

        public abstract int KovetkezoTipp();
    }
}
