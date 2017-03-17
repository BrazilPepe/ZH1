using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2F_ZH1
{
    public class Verseny
    {
        public Random rnd = new Random();

       
        public int Szám;
        public int Haladás;

        public void Körök()
        {
            for (int i = 1; i < 100; i++) ;
               

        }


        public List<Versenyző> KVersenyző = new List<Versenyző>();

        public int i;

        public int SzámAdás()
        {

            for (i = 1; i < 10; i++)
                KVersenyző.Add(new Versenyző());
            return i;
        }

        public void Versenyzők()
        {
            Console.WriteLine("Versenyzők száma: 7");

            for (int i = 0; i < KVersenyző.Count; i++)
            {
                Console.WriteLine("{0}. Versenyzők:", i);
                KVersenyző[i].Versenyzők();
            }
        }


        public void Zsa()
        {
            throw new System.NotImplementedException();
        }

     
    }
}