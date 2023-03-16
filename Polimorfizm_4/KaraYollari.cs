using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm_4
{
    internal class KaraYollari:Ulasim
    {
        private string plakaNo; //7 haneli olmalı.
        private int turSayisi; //en fazla 10 olmalı.

        public double gunlukKazanc;

        public string PlakaNo
        {
            get { return plakaNo; }
            set
            {
                if (value.Length == 7)
                {
                    plakaNo = value;
                }
                else
                {
                    Console.WriteLine("Plaka 7 haneli olmalıdır.");
                }
            }

        }

        public int TurSayisi
        {
            get { return turSayisi; }
            set
            {
                if(value>=0 && value <= 10)
                {
                    turSayisi = value;
                }
                else
                {
                    Console.WriteLine("Tur sayısı en fazla 10 olmalıdır.");
                }
            }
        }

        public void GelirVergisi(string guzergah, int TurSayisi ,double gunlukKazanc)
        {
            if(guzergah=="ataşehir" && TurSayisi <= 5)
            {
                double gelirVergisi = gunlukKazanc * 0.03;
                double haftalikKazanc = (gunlukKazanc + gelirVergisi) * 7;
                Console.WriteLine("Haftalık Kazanç: " +haftalikKazanc);
            }
            else if(guzergah=="gebze" && TurSayisi > 5)
            {
                double gelirVergisi = gunlukKazanc * 0.06;
                double haftalikKazanc = (gunlukKazanc + gelirVergisi) * 7;
                Console.WriteLine("Haftalık Kazanç: " + haftalikKazanc);
            }
        }
     
        public void KaraVeri()
        {
            AnaVeri();
            
            Console.WriteLine("---------------KARA YOLLARI HAFTALIK KAZANÇ----------------");
            Console.WriteLine("Plaka no giriniz(7 haneli olmalı): ");
            PlakaNo = Console.ReadLine();
            Console.WriteLine("Tur Sayısını giriniz(0-10 arasında olmalı): ");
            TurSayisi=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Günlük kazancı giriniz: ");
            gunlukKazanc=Convert.ToDouble(Console.ReadLine());

            GelirVergisi(Guzergah,TurSayisi,gunlukKazanc);
        }


    }
}
