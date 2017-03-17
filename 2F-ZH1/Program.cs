using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2F_ZH1
{
    class Program
    {
        static void Main(string[] args)
        {

            Verseny V1 = new Verseny();
            {
                Csiga Csiga = new Csiga( 1, 50);
                Hóvirág h = new Hóvirág();
                Medve m = new Medve();
                TréMedve tm = new TréMedve();
                Róka r = new Róka();
                Szöcske sz = new Szöcske();
                Nyúl ny = new Nyúl();
            }
            
            Console.ReadKey();
        }         
  }
}


