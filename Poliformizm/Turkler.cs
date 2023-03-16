using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliformizm
{
    internal class Turkler:Insan
    {
        public override void SelamVer()
        {
            base.SelamVer();    //Ana classdaki metot içiçn aynısını getirmek için "base"
        }
    }
}
