using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliformizm_2
{
    internal class KislikAyakkabi:Ayakkabilar
    {
        public string durum;

        public override double Indirim(double Fiyat, string marka)  //Virtual olan ana classdaki metotu overridelamak gerekir. yani ezmek
        {
            if (marka == "bambi")
            {
                Fiyat -= Fiyat * 0.5;
                return Fiyat;
            }
            else
            {
                Fiyat -= Fiyat * 0.3;
                return Fiyat;
            }
        }



    }
}
