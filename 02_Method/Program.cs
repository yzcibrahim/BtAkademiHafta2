﻿using System;

namespace _02_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(TamsayiDonenMethod());
            //int s = TamsayiDonenMethod();
            while (true)
            {
                int aa = Convert.ToInt32(Console.ReadLine());
                int ouutOlarakGelenParametre;
                if (CiftMi(aa,out ouutOlarakGelenParametre))
                {
                    Console.WriteLine($"{aa} çifttir");
                }
                else
                {
                    Console.WriteLine($"{aa} tektir");
                }
            }

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

        static bool BoolMethod()
        {
            return true;
        }

        static bool CiftMi(int a,out int oupParam)
        {
            oupParam = 54;
            if (a%2==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        static int TamsayiDonenMethod()
        {
            return 1;
        }

        static int Toplam(int a, int b=0)
        {
            return a+b;
        }
    }
}
