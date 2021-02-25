using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //aktif etmek içi diyezleri kaldır ama değişkenlerin çakışmaması için burayı kaldırıyorsan aşağıdakilere diyez ekle.
            //string[] kurslar = new string[] { "Yazılım Geliştirme Kursu", "Programlamaya Başlangıç için Temel Kurs", "Java" };
            //for (int i = 0; i < 3; i++)
            //{
                //Console.WriteLine(kurslar[i]);
            //}
            
            //string[] kurslar = new string[] { "Yazılım Geliştirme Kursu", "Programlamaya Başlangıç için Temel Kurs", "Java","Python" };
            //for (int i = 0; i < kurslar.Length; i++)
            //{
                //Console.WriteLine(kurslar[i]);
            //}
            //Console.WriteLine("For Bitti");

            string[] kurslar = new string[] { "Yazılım Geliştirme Kursu", "Programlamaya Başlangıç için Temel Kurs", "Java", "Python" };
            foreach (string kurs in kurslar) 
            {
                Console.WriteLine(kurs);
            }




            //for (int i = 1; i < 10; i++)
            //{
            //Console.WriteLine(i);
            //}
        }
    }
}
