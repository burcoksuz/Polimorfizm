using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliformizm_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KislikAyakkabi ayakkabi1 = new KislikAyakkabi();

            ayakkabi1.Tum();

            Console.WriteLine("Son tutar: " + ayakkabi1.Indirim(ayakkabi1.Fiyat,ayakkabi1.marka)); //returnlu metot

            ayakkabi1.Ozellik(ayakkabi1.marka,ayakkabi1.Model); //void metot



            Console.ReadLine();
        }
    }
}
