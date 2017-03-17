using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2F_ZH1
{
    public class Verseny
    {
        public Random rnd = new Random(100);

       
        public int Szám;
        public float Haladás;

        public void Körök()
        {
            for (int i = 1; i < 100; i++) ;
               

        }


        public List<Versenyző> Versenyzőkk = new List<Versenyző>();

        public int i;

        public int SzámAdás()
        {

            for (i = 1; i < 10; i++)
                Versenyzőkk.Add(new Versenyző());
            return i;
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
        
           public bool Zsa()
        { 
           return mehete;
        }



}
}