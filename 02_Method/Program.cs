using System;

namespace _02_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Method nedir");
            IlkMethod();
            Selamla("ibrahim");
            Selamla("yazıcı");

            Console.WriteLine("Sayı 1 giriniz");
            string girilenDeger = Console.ReadLine();
            int sayi1 = Convert.ToInt32(girilenDeger);
            
            Console.WriteLine("Sayı 2 giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int tpl = Toplam(sayi1,sayi2);

            Console.WriteLine(tpl);
            tpl = Toplam(sayi1);
        }

        static void IlkMethod()
        {
            Console.WriteLine("ben ilk methodum");
        }
        static void Selamla(string kim)
        {
            Console.WriteLine("merhaba" + kim);
        }

        static int Toplam(int a, int b=0)
        {
            return a+b;
        }
    }
}
