using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2F_ZH1
{
    public class Verseny
    {
        public Random rnd = new Random(100);

        public int Körök = 100;
        public int Szám;
        public float Lépés;

        public List<Versenyző> Versenyzőkk = new List<Versenyző>();

        public int i;

        public void Adatok()
        {
            Console.WriteLine("Rajtszám: {0}", Szám);
            Console.WriteLine("Sebessége: {1}", Lépés);
        }

        public void SzámAdás()
        {

            for (i = 1; i < 10; i++)
               Versenyzőkk.Add(new Versenyző());
            
        }

        public void Versenyzők()
        {
            Console.WriteLine("Versenyzők száma: 7");

            for (int i = 0; i < Versenyzőkk.Count; i++)
            {
                Console.WriteLine("{0}. Versenyzők:", i);
                Versenyzőkk[i].Versenyzők();
            }
        }
        public bool mehete = true;
       
   }
}