using System;

namespace Ders2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("isim giriniz:");
            string ad = Console.ReadLine();

            Console.WriteLine("soy isim giriniz:");
            string soyAd = Console.ReadLine();

            string selamla = "merhaba " + ad + " " + soyAd;

            string selamla1 = string.Format("merhaba {0} {1}", ad, soyAd);

            string selamla2 = "merhaba {ad} {soyAd}";
            string selamla3 = $"merhaba {ad} {soyAd}";



            string user = "test";
            //user = Console.ReadLine();
            Console.WriteLine("Hello World!"+ user);

            int a = 10;
            int b = 4;
            double sonuc=a+b;
            Console.WriteLine("toplam:"+ sonuc);
            sonuc = a - b;
            Console.WriteLine("fark:"+sonuc);
            sonuc = a * b;
            Console.WriteLine("çarpım"+sonuc);
            sonuc = (double)a / (double)b;
            Console.WriteLine("bölüm"+sonuc);
            sonuc = a % b;
            Console.WriteLine("bölümünden kalan:"+sonuc);


            string test = "asdasfsdf skjdnf ksdl";
            Char chra = 'A';

        }
        
    }
}
