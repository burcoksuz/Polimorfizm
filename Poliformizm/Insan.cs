using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliformizm
{
    abstract internal class Insan                //ANA CLASS
    {
        public int yas;
        public string cinsiyet;

        //poliformizmde iki anahtar kelime vardır. 

        //1- Virtual(sanal): ana classlarda 
        //2- Ovverride(ezmek,aşmak,üstüne geçmek): yavru classlarda kullanılıyor.


        public virtual void SelamVer()
        {
            Console.WriteLine("Selamun Aleyküm");
        }


    }


    
}
