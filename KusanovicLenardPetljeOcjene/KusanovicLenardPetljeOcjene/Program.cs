using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KusanovicLenardPetljeOcjene
{
    class Program
    {
        static void Main(string[] args)
        {
            int ocjena;
            float prosjek;
            float brojOcjena = 0;
            int zbrojOcjena = 0;

            do
            {




                Console.WriteLine("Upisite ocjenu: ");
                ocjena = Convert.ToInt16(Console.ReadLine());
               
                

                 if (ocjena == 1)
                {
                    prosjek = 1;
                    break;
                }


                else if (ocjena > 5 || ocjena < 0)
                {
                    Console.WriteLine("Pogresan unos unesite ponovo ");
                    
                }
                else if (ocjena !=0){
                    brojOcjena++;
                    zbrojOcjena +=ocjena;


                    

                }
                prosjek = zbrojOcjena / brojOcjena;
            }
            while (ocjena != 0);

            Console.WriteLine("Prosjek ocjena je: "+ prosjek);
            Console.ReadKey();

        }
    }
}
