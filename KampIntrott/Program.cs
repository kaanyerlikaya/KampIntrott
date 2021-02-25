using System;

namespace KampIntrott
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            //bool sistemeGirisYapmisMi = true;
            
            //if (sistemeGirisYapmisMi == true)       
            //{
                //Console.WriteLine("Kullanıcı ayarları butonu");
            //}

            bool sistemeGirisYapmisMi = false;

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }
            
            Console.WriteLine(kategoriEtiketi);
            
            Console.WriteLine(kategoriEtiketi);
            
            Console.WriteLine(kategoriEtiketi);
            
            Console.WriteLine(kategoriEtiketi);
            
            Console.WriteLine(kategoriEtiketi);


            //KENDİ ÇALIŞMALARIM - ÇALIŞMASI İÇİN DİYEZ(//) İŞARETLERİNİ KALDIR.
            //string site = "Çaylak Yazılımcı";
            //string mesaj = "Merhaba!";

            //Console.WriteLine(site);
            //Console.WriteLine(mesaj);
            //Console.WriteLine(mesaj + " " + site);
            //---------------------------------------------
            
            
            //int ogrenciSayisi = 32000;
            //int ogretmenSayisi = 100;

            //Console.WriteLine("Öğrenci Sayısı:" + ogrenciSayisi);
            //Console.WriteLine("Öğretmen Sayısı:" + ogretmenSayisi);
            //---------------------------------------------
            
            
            //double notOrt1 = 67.5;
            //double notOrt2 = 58.3;

            //Console.WriteLine("Türkçe Not Ortalaması:" + notOrt1);
            //Console.WriteLine("Fen Not Ortalaması:" + notOrt2);
            //--------------------------------------------
            
            
            //bool dogru = true;
            //bool yanlis = false;
            //int sayi = 5;
            //bool sonuc = sayi > 10;
            //Console.WriteLine(dogru);
            //Console.WriteLine(yanlis);
            //Console.WriteLine(sonuc);
            //--------------------------------------------
            
            
            //int sayi = 7;
            //Console.WriteLine("Kontrol Edilecek Sayı:" + sayi);

            //if (sayi > 0)
            //{
            //    Console.WriteLine("Verilen Sayı Pozitiftir");
            //}
            //-------------------------------------------
            
            
            //int sayi = -7;
            //Console.WriteLine("Kontrol edilecek sayı:" + sayi);

            //if (sayi > 0)
            //{
            //Console.WriteLine("Verilen sayı pozitiftir");
            //}
            //else
            //{
            //Console.WriteLine("Verilen sayı negatiftir");
            //}
            //------------------------------------------
            
            
            //int sayi = 0;
            //Console.WriteLine("Kontrol edilecek sayı:" + sayi);

            //if (sayi>0)
            //{
                //Console.WriteLine("Verilen sayı pozitiftir");
            //}
            //else if (sayi<0)
            //{
                //Console.WriteLine("Verilen sayı negatiftir");
            //}
            //else
            //{
                //Console.WriteLine("Verilen sayı sıfırdır");
            //}
            //------------------------------------------


        }
    }
}
