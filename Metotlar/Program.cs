using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 20;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 15;

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Ürün Adı:" + urun.Adi + "\n" + "Ürün Fiyatı:" + urun.Fiyati + "\n" + "Açıklama:" + urun.Aciklama 
                    + "\n" + "Stok Adedi:" + urun.StokAdedi + "\n" + "--------------");
            }

            Console.WriteLine("--------------Metotlar-------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


        }
    }
}
