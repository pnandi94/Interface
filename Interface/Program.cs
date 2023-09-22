using Interface;
using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        SzamKitalaloJatek jatek = new SzamKitalaloJatek(0, 20);
        VeletlenTippelo veletlenTippelo = new VeletlenTippelo();
        BejaroTippelo bejaroTippelo = new BejaroTippelo();
        LogaritmikusKereso logaritmikusKereso = new LogaritmikusKereso();

        jatek.VersenyzoFelvetele(veletlenTippelo);
        jatek.VersenyzoFelvetele(bejaroTippelo);
        jatek.VersenyzoFelvetele(logaritmikusKereso);

        Teszt(jatek);
        //jatek.Statisztika(100);
    }

    static void Teszt(SzamKitalaloJatek jatek)
    {
        EmberiJatekos emberiJatekos = new EmberiJatekos();
        jatek.VersenyzoFelvetele(emberiJatekos);
        jatek.Jatek();
    }
}