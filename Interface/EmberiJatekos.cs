using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class EmberiJatekos : IOkosTippelo
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

        public void Nyert()
        {
            Console.WriteLine("*Nyertél!");
        }

        public void Veszitett()
        {
            Console.WriteLine("*Veszítettél!");
        }
    }

}
