using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2F_ZH1
{
    public class Versenyző : Verseny
    {

        public void SzámAdás()
        {
            throw new System.NotImplementedException();
        }

        public List<Versenyző> Versenyzőkk = new List<Versenyző>();

        public virtual void Listazas()
        {
            foreach (Versenyző v in Versenyzőkk)
            {
                Console.WriteLine("Versenyzők száma:", Versenyzőkk);
            }
        }




    }

}