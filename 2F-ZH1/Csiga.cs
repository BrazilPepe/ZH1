using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2F_ZH1
{
    public class Csiga : Verseny, Ijesztes
    {
        public static int LábakSzáma = 0;

        public void Ijeszto()
        {
            Haladás = Haladás * (float)0.5;
            
        }

        public void SzamKapas(int Szam)
        {
            this.i = Szam;
            Console.WriteLine("Szám: ", Szam);
        }

        /* public TréMedve Kiálltás()
         {

         } */
    }
}