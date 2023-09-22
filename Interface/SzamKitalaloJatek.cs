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
        private int alsoHatar;
        private int felsoHatar;
        public int cel;

        public SzamKitalaloJatek(int alsoHatar, int felsoHatar)
        {
            this.versenyzok = new ITippelo[MAX_VERSENYZO];
            this.versenyzoN = 0;
            this.alsoHatar = alsoHatar;
            this.felsoHatar = felsoHatar;
        }

        public void VersenyzoFelvetele(ITippelo jatekos)
        {
            if (versenyzoN < MAX_VERSENYZO)
            {
                versenyzok[versenyzoN++] = jatekos;
            }
            else
            {
                Console.WriteLine("Maximum versenyző szám elérve.");
            }
        }

        public void VersenyIndul()
        {
            Random random = new Random();
            cel = random.Next(alsoHatar, felsoHatar + 1);

            foreach (ITippelo jatekos in versenyzok)
            {
                if (jatekos != null)
                {
                    jatekos.JatekIndul(alsoHatar, felsoHatar);
                }
            }

            //Console.WriteLine("A cél száma: " + cel);
        }

        public bool MindenkiTippel()
        {
            bool vanNyertes = false;
            foreach (ITippelo jatekos in versenyzok)
            {
                if (jatekos != null)
                {
                    int tipp = jatekos.KovetkezoTipp();
                    if (tipp == cel)
                    {
                        jatekos.Nyert();
                        vanNyertes = true;
                    }
                    else if (jatekos is IOkosTippelo)
                    {
                        if (tipp < cel)
                        {
                            ((IOkosTippelo)jatekos).Nagyobb();
                        }
                        else
                        {
                            ((IOkosTippelo)jatekos).Kisebb();
                        }
                    }
                    Console.WriteLine($"{jatekos.GetType().Name} tippje: {tipp}");
                }
            }
            return vanNyertes;
        }

        public void Jatek()
        {
            VersenyIndul();
            bool jatekVege = false;

            while (!jatekVege)
            {
                jatekVege = MindenkiTippel();
            }

            List<ITippelo> gyoztesek = new List<ITippelo>();
            foreach (ITippelo versenyzo in versenyzok)
            {
                if (versenyzo != null && versenyzo is GepiJatekos)
                {
                    GepiJatekos gepiJatekos = (GepiJatekos)versenyzo;
                    if (gepiJatekos.NyertDB > 0)
                    {
                        gyoztesek.Add(gepiJatekos);
                    }
                }
            }
            if (gyoztesek.Count > 0)
            {
                Console.WriteLine("Győztes(ek):");
                foreach (ITippelo gyoztes in gyoztesek)
                {
                    Console.WriteLine(gyoztes.GetType().Name);
                    Console.WriteLine("A cél száma: " + cel);
                }
            }
        }
        public void Statisztika(int korokSzama)
        {
            for (int i = 0; i < korokSzama; i++)
            {
                Jatek();
            }

            Console.WriteLine("Statisztika:");
            foreach (var versenyzo in versenyzok)
            {
                if (versenyzo is IStatisztikatSzolgaltat)
                {
                    var statisztikaVersenyzo = (IStatisztikatSzolgaltat)versenyzo;
                    Console.WriteLine($"{versenyzo.GetType().Name} - Nyert: {statisztikaVersenyzo.HanyszorNyert}, Vesztett: {statisztikaVersenyzo.HanyszorVesztett}");
                }
            }
        }
    }
}
