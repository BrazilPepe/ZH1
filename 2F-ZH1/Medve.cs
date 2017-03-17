using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2F_ZH1
{
    public class Medve : Verseny
    {
        Medve Bolha = new Medve();
        

        public static int LábakSzáma = 4;

        public void SzamKapas(int Szam)
        {
            this.i = Szam;
            Console.WriteLine("Szám: ", Szam);
        }
    
    }
}