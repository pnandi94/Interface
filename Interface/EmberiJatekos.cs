using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class EmberiJatekos : IOkosTippelo, IJatekos
    {
        public void JatekIndul(int alsoHatar, int felsoHatar)
        {
            Console.WriteLine($"*Játék indul az alábbi határok között: [{alsoHatar},{felsoHatar}]");
        }

        public void Kisebb()
        {
            Console.WriteLine("*Az előző tippnél kisebb a keresett szám");
        }

        public void Nagyobb()
        {
            Console.WriteLine("*Az előző tippnél nagyobb a keresett szám");
        }

        public int KovetkezoTipp()
        {
            Console.Write("*Add meg a következő tippet:");
            int tipp = int.Parse(Console.ReadLine());
            Console.WriteLine($" Interfesz.EmberiJatekos tippje:{tipp}");
            return tipp;
        }


        public int NyertDB { get; private set; }
        public int VeszitettDB { get; private set; }

        public void Nyert()
        {
            NyertDB++;
            Console.WriteLine("*Nyertél!");
        }

        public void Veszitett()
        {
            VeszitettDB++;
            Console.WriteLine("*Veszítettél!");
        }
    }

}
