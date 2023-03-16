using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliformizm_2
{
    abstract internal class Ayakkabilar //Ana Class: Abstract yaptık. 
    {   
        public string marka;
        
        private double fiyat;
        private string model;



        public double Fiyat  //property
        {
            get { return fiyat; }
            set
            {
                if(value>1000 && value < 5000)
                {
                    fiyat = value;
                }
                else
                {
                    Console.WriteLine("Fiyat Hatalı.");
                }
            }
        }



        public string Model //property
        {
            get { return model; }
            set
            {
                if(value=="spor" || value == "klasik")
                {
                    model = value;
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }


        public virtual double Zam(double Fiyat,string marka)
        {
            if(marka=="adidas" || marka == "nike")
            {
                Fiyat += Fiyat * 20 / 100;
                return Fiyat;
            }
            else
            {
                Fiyat += Fiyat * 5 / 100;
                return Fiyat;
            }
        }


        public virtual double Indirim(double Fiyat, string marka)
        {
            if (marka == "puma" || marka == "new balance")
            {
                Fiyat -= Fiyat * 5 / 100;
                return Fiyat;
            }
            else
            {
                Fiyat -= Fiyat * 20 / 100;
                return Fiyat;
            }
        }



        public virtual void Ozellik(string marka, string Model)
        {
            if(marka=="nike" && Model == "spor")
            {
                Console.WriteLine("2 yıl garantilil temizleme spreyi bedava");
            }
            else
            {
                Console.WriteLine("Sadece 1 yıl garanti ve 50 TL indirim çeki");
            }
        }



        public void Tum()
        {
            Console.WriteLine("Fiyat giriniz: ");
            Fiyat=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Marka giriniz(adidas,nike,puma,new balance,diğer..): ");
            marka=Console.ReadLine();

            Console.WriteLine("Model giriniz(spor, klasik, diğer..): ");
            Model=Console.ReadLine();

            //Yazdırma:
            Console.WriteLine("Fiyat: " +Fiyat);
            Console.WriteLine("Marka: " +marka);
            Console.WriteLine("Model: " +Model);
        }










    }
}
