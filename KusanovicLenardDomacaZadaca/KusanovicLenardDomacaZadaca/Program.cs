using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KusanovicLenardDomacaZadaca
{
    class Program
    {
        static void Main(string[] args)
        {
            int brojac = 0;
            float prosjek = 0;

            Console.WriteLine("Upisite ocjene. Kad ste gotovi upisite 0");
        pogreska:

            float ocjena = Convert.ToInt32(Console.ReadLine());

            do
            {

                if (ocjena == 1)
                {
                    Console.WriteLine("Prosjek ocjena je 1 ");
                    goto gotovo;
                }
                if (ocjena < 1 || ocjena > 5)
                {
                    Console.WriteLine("Kriva ocjena Upisi opet");
                    goto pogreska;
                }
                prosjek = prosjek + ocjena;
                brojac++;
                ocjena = Convert.ToInt32(Console.ReadLine());
            } while (ocjena != 0);

            prosjek = prosjek / brojac;
            Console.WriteLine("Prosjek ocjena je: " + prosjek);

        gotovo:

            Console.ReadKey();

        }
    }
}
