using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2F_ZH1
{
    public class Nyúl : Verseny, Ijesztes
    {
        public static int LábakSzáma = 4;

        public void SzamKapas(int Szam)
        {
            this.i = Szam;
            Console.WriteLine("Szám: ", Szam);
        }

        public void Ijeszto()
        {
            Lépés = Lépés * (float)1.5;
        }

        /*public Sebesség(Haladás)
        {
            if (kiálltás = true)
                Haladás = Haladás * 1.5;
            return Haladás; 
        } */
    }
}