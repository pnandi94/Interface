using Interface;
using System;

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

        jatek.Jatek();
    }
}