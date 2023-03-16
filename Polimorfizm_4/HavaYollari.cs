using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm_4
{
    internal class HavaYollari:Ulasim
    {
        public string firmaAdi;
        private string musteriTip;  //standart,ekonomik,bussiness olmalı.

        public string MusteriTip
        {
            get { return musteriTip; }
            set
            {
                if(value=="standart" || value=="ekonomik" || value == "business")
                {
                    musteriTip = value;
                }
                else
                {
                    Console.WriteLine("Hatalı girdi");
                }
            }
        }

        public void Bonus(string MusteriTip,double tutar)
        {
            if (MusteriTip == "business")
            {
                tutar += tutar * 0.2;
                Console.WriteLine("Son tutar: " +tutar);
            }
            else if(MusteriTip == "standart")
            {
                tutar += tutar * 0.15;
                Console.WriteLine("Son tutar: " + tutar);
            }
            else if (MusteriTip == "ekonomik")
            {
                tutar += tutar * 0.1;
                Console.WriteLine("Son tutar: " + tutar);
            }
            else
            {
                Console.WriteLine("Son tutar: " +tutar);
            }
        }


        public void HavaVeri()
        {
            AnaVeri();
            Console.WriteLine("Firma Adı giriniz:");
            firmaAdi = Console.ReadLine();
            Console.WriteLine("Müşteri Tip giriniz(standart,ekonomik,bussiness):");
            MusteriTip=Console.ReadLine();

            
            Bonus(MusteriTip,tutar);
        }

    }
}
