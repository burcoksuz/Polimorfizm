using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm_4
{
    abstract internal class Ulasim
    {
        private string seferNo;     // 4 haneli olucak
        private string seferAd;    //sehir ici olmalı
        private string guzergah;     //gebze veya ataşehir veya bagcılar olmalıdır

        public double tutar;

        public string soforAd;
        public double biletFiyat;
        public int adet;


        public string SeferNo
        {
            get { return seferNo; }
            set
            {
                if (value.Length == 4)
                {
                    seferNo = value;
                }
                else
                {
                    Console.WriteLine("Hatalı girdi! Sefer no 4 haneli olmalıdır.");
                }
            }

        }


        public string SeferAd
        {
            get { return seferAd; }
            set
            {
                if(value=="şehir içi")
                {
                    seferAd = value;
                }
                else
                {
                    Console.WriteLine("Sadece şehir içine ulaşım sağlanmaktadır.");
                }
            }
        }

        public string Guzergah
        {
            get { return guzergah; }
            set
            {
                if(value=="gebze" || value=="ataşehir" || value == "bagcılar")
                {
                    guzergah = value;
                }
                else
                {
                    Console.WriteLine("Ulaşım güzergahı: Gebze, Ataşehir veya Bağcılara yapılmakltadır.");
                }
            }
        }


        public double FiyatHesaplama(double fiyat, int adet)
        {
            fiyat *= adet;
            return fiyat;
        }


        public virtual double KDV(double fiyat)
        {
            fiyat += fiyat * 0.05;
            return fiyat;
        }


        public virtual double Vergi(double fiyat)
        {
            if(fiyat >=100 && fiyat < 500)
            {
                fiyat += fiyat * 0.02;
                return fiyat;
            }
            else if(fiyat>=500 && fiyat <= 10000)
            {
                fiyat += fiyat * 0.05;
                return fiyat;
            }
            else
            {
                return fiyat;
            }
        }


        public void AnaVeri()
        {
            Console.WriteLine("Sefer no giriniz(4 haneli olmalı): ");
            SeferNo = Console.ReadLine();

            Console.WriteLine("Sefer ad giriniz(şehir içi): ");
            SeferAd=Console.ReadLine();

            Console.WriteLine("Güzergah giriniz(ataşehir,gebze,bağcılar): ");
            Guzergah = Console.ReadLine();

            Console.WriteLine("Şöfor adını giriniz: ");
            soforAd=Console.ReadLine();

            Console.WriteLine("Bilet fiyatını giriniz: ");
            biletFiyat = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bilet Adeti giriniz: ");
            adet = Convert.ToInt32(Console.ReadLine());


            //yazdırma:
            Console.WriteLine("Sefer no:" +SeferNo);
            Console.WriteLine("Sefer ad:" +SeferAd);
            Console.WriteLine("Güzergah:" +Guzergah);
            Console.WriteLine("Bilet fiyatı:" +biletFiyat);
            Console.WriteLine("Bilet adeti:" +adet);

            tutar = FiyatHesaplama(biletFiyat, adet);
            Console.WriteLine("Toplam tutar: "+tutar);
            double kdv = KDV(tutar);
            Console.WriteLine("Kdv'li tutar: "+kdv);
            double vergi=Vergi(kdv);
            Console.WriteLine("Vergili Tutar: "+vergi);

        }
    }
}
