using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliformizm
{
    internal class Ingilizler:Insan
    {
        public int para;

        public override void SelamVer()  //Metot aynı ama içindeki farklı. (virtual => Override a dönüşür.)
        {
            Console.WriteLine("Hello everyone");
        }
    }
}
