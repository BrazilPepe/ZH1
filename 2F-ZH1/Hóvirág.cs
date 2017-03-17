using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2F_ZH1
{
    public class Hóvirág : Verseny
    {
        public static int LábakSzáma = 0;
        public static int Haladás = 0;
        public void SzamKapas(int Szam)
        {
            this.i = Szam;
            Console.WriteLine("Szám: ", Szam);
        }


    }
}