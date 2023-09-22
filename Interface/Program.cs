using Interface;
using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        //SzamKitalaloJatek jatek = new SzamKitalaloJatek(0, 20);
        SzamKitalaloJatekKaszino kaszinoJatek = new SzamKitalaloJatekKaszino(0, 20, 10);
        VeletlenTippelo veletlenTippelo = new VeletlenTippelo();
        BejaroTippelo bejaroTippelo = new BejaroTippelo();
        LogaritmikusKereso logaritmikusKereso = new LogaritmikusKereso();
        EmberiJatekos emberiJatekos = new EmberiJatekos();

        /*
        jatek.VersenyzoFelvetele(veletlenTippelo);
        jatek.VersenyzoFelvetele(bejaroTippelo);
        jatek.VersenyzoFelvetele(logaritmikusKereso);
        */
        //Teszt(jatek);

        //jatek.Statisztika(100);

        kaszinoJatek.VersenyzoFelvetele(veletlenTippelo);
        kaszinoJatek.VersenyzoFelvetele(bejaroTippelo);
        kaszinoJatek.VersenyzoFelvetele(logaritmikusKereso);
        kaszinoJatek.VersenyzoFelvetele(emberiJatekos);

        kaszinoJatek.Jatek();
    }

    static void Teszt(SzamKitalaloJatek jatek)
    {
        EmberiJatekos emberiJatekos = new EmberiJatekos();
        jatek.VersenyzoFelvetele(emberiJatekos);
        jatek.Jatek();
    }
}