using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPCokBicimlilikOrnek
{
    public class Banka
    {
        public string bankaAdi { get; set; }


        private decimal alisverisTutari = 0;

        public decimal AlisverisTutari
        {
            get { return alisverisTutari; }
            set { alisverisTutari = value; }
        }

        public void BilgileriAl()
        {
            Console.WriteLine(bankaAdi + " bankasına hoşgeldiniz..");
            Console.WriteLine("Alışveriş tutarı giriniz: ");
            alisverisTutari = decimal.Parse(Console.ReadLine());

            if (alisverisTutari > 0)
            {
                AlisverisTutari = alisverisTutari;
            }
            else
            {
                throw new Exception("Tutar sıfırdan büyük olmalıdır.");
            }
        }

        public virtual void IndirimOraninaGoreIndirimYap()
        {
            AlisverisTutari -= AlisverisTutari * 0.20m;
            Console.WriteLine("%20 indirim uygulandı..");
            Console.WriteLine("Ödenecek Tutar: " + AlisverisTutari);
        }

    }
}
