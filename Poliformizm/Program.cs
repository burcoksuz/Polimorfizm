using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliformizm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Poliformizm:(çok şekillilik,çok biçimlilik)
            //ana classda gövdesi yazılır
            //Yavru classlarda var olan method ezilerek kendi işlemlerini yapabilir.

            //Abstract: Soyutlamak.
            //Ana classların genellikle soyut olması gerekir.bu yüzden ana classın basına abstract yazarsak artık o class tamamen soyutlanmış ve nesne üretemez hale gelmiştir.Fakat içindeki üyelere erişmek kalıtım yapmak gerekir. ve yavru classın nesne üreterek ana classdaki üyeleri kullanması sağlanabilir. 
           // abstract Ve interface olan classlardan nesne üretilemez. 

             //NOT:  Insan ınsan = new Insan(); //hata verir. çünkü ana class abstract. 

            Turkler turkler = new Turkler();
            turkler.SelamVer();

            Ingilizler ingilizler = new Ingilizler();
            ingilizler.SelamVer();

            Iskoclar iskoclar = new Iskoclar();
            iskoclar.SelamVer();


            Console.ReadKey();
        }
    }
}
