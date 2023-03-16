using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm_4
{
    internal class Program
    {
        /*
                     * Ulasım (ana class)(abstract olmalı)
            --------------------------------------------------------------
            seferno      4 haneli olucak 
            seferad      sehirci olmalı
            guzergah     gebze veya ataşehir veya bagcılar olamlıdır
            soförad 
            biletfiyat
            adet

            ANA CLASSDA  
            1.METHOD RETURN METHOD  FİYAT HESAPLAMA METHODU 
            2.METHOD  POLİFORMİZLİ RETURN LU METHOD 1.METHODDAN GELEN VERİYE KDV EKLE (%5)
            3.METHOD POLİFORMİZLİ VOİDLİ METHOD  2.METHODDAN GELEN FİYATI  GÖRE 
            FİYAT 100 İLE 500 ARASINDA İSE %2 VERGİ
            FİYAT 500 İLE 1000 ARASINDA İSE %5 VERGİ
         */
        
        //Not: int tanımlı ise Boyu: "value.ToString().Length>6"
        


        static void Main(string[] args)
        {
            KaraYollari karaYollari = new KaraYollari();
            karaYollari.KaraVeri();

            HavaYollari havaYollari = new HavaYollari();    
            havaYollari.HavaVeri();

            Console.ReadLine();
        }
    }
}
