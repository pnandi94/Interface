using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class SzamKitalaloJatek
    {
        private const int MAX_VERSENYZO = 5;
        private ITippelo[] versenyzok = new ITippelo[MAX_VERSENYZO];
        private int versenyzoN;
        public int cel;

        public SzamKitalaloJatek(int alsoHatar, int felsoHatar)
        {
            this.cel = new Random().Next(alsoHatar, felsoHatar + 1);
            this.versenyzoN = 0;
        }

        public void VersenyzoFelvetele(ITippelo jatekos)
        {
            if (versenyzoN < MAX_VERSENYZO)
            {
                versenyzok[versenyzoN] = jatekos;
                versenyzoN++;
            }
            else
            {
                Console.WriteLine("Maximum versenyző szám elérve.");
            }
        }

        public void VersenyIndul()
        {
            foreach (ITippelo jatekos in versenyzok)
            {
                if (jatekos != null)
                {
                    jatekos.JatekIndul(cel - 1, cel + 1);
                }
            }
        }

        public bool MindenkiTippel()
        {
            bool vanNyertes = false;
            foreach (ITippelo jatekos in versenyzok)
            {
                if (jatekos != null)
                {
                    int tipp = jatekos.KovetkezoTipp();
                    Console.WriteLine($"{jatekos.GetType().Name} tippelt: {tipp}");
                    if (tipp == cel)
                    {
                        jatekos.Nyert();
                        vanNyertes = true;
                    }
                }
            }

            if (vanNyertes)
            {
                foreach (ITippelo jatekos in versenyzok)
                {
                    if (jatekos != null)
                    {
                        if (jatekos.KovetkezoTipp() != cel)
                        {
                            jatekos.Veszitett();
                        }
                    }
                }
            }

            return vanNyertes;
        }

        public void Jatek()
        {
            VersenyIndul();
            while (!MindenkiTippel()) { }
        }
    }
}
