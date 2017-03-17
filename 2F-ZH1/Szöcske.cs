using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2F_ZH1
{
    public class Szöcske : Verseny
    {
        Random rnd = new Random();
        
       // public float Sebesség = ;
        

        public static int LábakSzáma = 6;

        public void SzamKapas(int Szam)
        {
            this.i = Szam;
            Console.WriteLine("Szám: ", Szam);
        }


    }
}