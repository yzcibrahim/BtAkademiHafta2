using System;

namespace KompleksTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region tiplerprimitive
            //int a=-6; uint,float=-5.5, long=, string, char,DateTime
            int a = 2147483647;
            long asd = 9223372036854775807;
            string str = "asdkansd lklka dlkamsdlka msdklnsamdklanmsşdlasşkdnjakls dklasmndşmalsd";
            char chr = 'A';
            #endregion

            Person p1 = new Person();
            p1.Ad = "ibrahim";
            p1.Soyad = "yaz";
            p1.Yas = 15;
           
            

            Person p2 = new Person();
            p2.Ad = "deneme AD";
            p2.Soyad = "deneme Soyad";
            p2.Yas = 38;
           
            Console.WriteLine(p1.Tanim());
            Console.WriteLine(p2.Tanim());

            // DateTime




            #region struct
            //Kisi k = new Kisi();
            //k.Ad = "ibrahim";
            //k.Soyad = "yzc";
            //k.Yas = 65;

            //Console.WriteLine(k);
            //Console.WriteLine($"ad:{k.Ad} soyad:{k.Soyad} yaş:{k.Yas}");
            //Console.WriteLine(k.Yazdir());

            //Kisi k1 = new Kisi() { Ad = "deneme", Soyad = "Test", Yas = 25 };

            //string k1Yazi = k1.Yazdir();
            //Console.WriteLine(k1Yazi);
            #endregion
        }
    }
}
