using Interface;
using System;

class Program
{
    static void Main(string[] args)
    {
        SzamKitalaloJatek jatek = new SzamKitalaloJatek(10, 20);

        ITippelo gepi1 = new VeletlenTippelo();
        ITippelo gepi2 = new BejaroTippelo();

        jatek.VersenyzoFelvetele(gepi1);
        jatek.VersenyzoFelvetele(gepi2);

        Console.WriteLine("Játék indult!");
        Console.WriteLine($"Cél: {jatek.cel}");

        jatek.Jatek();

        Console.WriteLine("Játék vége!");
        Console.WriteLine($"Cél: {jatek.cel}");
        Console.WriteLine($"Gépi 1 nyert: {((GepiJatekos)gepi1).nyertDB} alkalommal");
        Console.WriteLine($"Gépi 2 nyert: {((GepiJatekos)gepi2).nyertDB} alkalommal");
    }
}