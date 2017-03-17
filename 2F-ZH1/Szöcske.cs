using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2F_ZH1
{
    public class Szöcske : Verseny
    {
        public static int LábakSzáma = 6;

        Random rns = new Random(100);
        
       

        public int Pihenés()
        {
            Lépés = Lépés - rnd.Next(1, 100);
            return (int)Lépés;
        } 
       
        public void SzamKapas(int Szam)
        {
            this.i = Szam;
            Console.WriteLine("Szám: ", Szam);
        }
    }
}