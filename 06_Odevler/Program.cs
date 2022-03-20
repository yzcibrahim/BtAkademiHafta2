using System;

namespace _06_Odevler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Odev1DiziYazdir();
            //Odev2KarelerToplami();
            // Odev3MinMaxToplami();
            //Odev4AsalMi();
            //Odev5IlkNAsalSayi();
            Odev6SayilarinKareleri();
            
        }

        

        static void Odev1DiziYazdir()
        {
            int[] dizi = DiziOlustur();
            DiziYazdir(dizi);

        }

        static void Odev2KarelerToplami()
        {
            int[] dizi = DiziOlustur();

            int karelerToplami = 0;

            for(int i=0;i<dizi.Length;i++)
            {
                karelerToplami += dizi[i] * dizi[i];
            }

            Console.WriteLine($"Dizinin kareler toplamı={karelerToplami}");
            for (int i = dizi.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"Diiznin {i}. elemanının Karesi:{dizi[i] * dizi[i]}");
            }

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine($"Diiznin {dizi.Length-1-i}. elemanının Karesi:{dizi[dizi.Length - 1 - i] * dizi[dizi.Length - 1 - i]}");
            }

        }
        static void Odev3MinMaxToplami()
        {
            int[] dizi = DiziOlustur();

            int min = dizi[0];
            int max = dizi[0];

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] < min)
                {
                    min = dizi[i];
                }
                if (dizi[i] > max)
                {
                    max = dizi[i];
                }
            }
            int minMaxToplami = min + max;
            Console.WriteLine($"min max toplamı={minMaxToplami}");

        }

        static void Odev4AsalMi()
        {
            int a = 0;

            while (true)
            {
                Console.WriteLine("Sayı giriniz: Çıkış için -1");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == -1)
                {
                    break;
                }

                if (a < 0)
                {
                    Console.WriteLine("Değer Pozitif Bir Tamsayı Olmalı!");
                    continue;
                }

                if (a<2)
                {
                    continue;
                }
                if (AsalMi(a))
                {
                    Console.WriteLine($"{a} ASAL!");
                }
                else
                {
                    Console.WriteLine($"{a} ASAL DEĞİL!");
                }
            }

        }

        static void Odev5IlkNAsalSayi()
        {
            Console.WriteLine("ilk kaç asal sayıyı arıyorsunuz");
            int n = Convert.ToInt32(Console.ReadLine());
            int asalAdeti = 0;
            //for(int i=2;;i++)
            //{
            //    if (AsalMi(i))
            //    {
            //        asalAdeti++;
            //        Console.WriteLine(i);
            //    }
            //    if(asalAdeti==n)
            //    {
            //        break;
            //    }
            //}
            int bakilacaksayi = 2;
            while (true)
            {
                if (AsalMi(bakilacaksayi))
                {
                    asalAdeti++;
                    Console.WriteLine($"{asalAdeti}.asal sayı={bakilacaksayi}");
                }
                if (asalAdeti == n)
                    break;

                bakilacaksayi++;
            }

        }

        static void Odev6SayilarinKareleri()
        {
            Console.WriteLine("Sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= sayi; i++)
            {
                int karesi = i * i;
                if (karesi % 2 == 1)
                {
                    continue;
                }
                if(karesi<225)
                    Console.WriteLine($"sayı={i} karesi={karesi}");
                else
                {
                    break;
                }
            }

        }
        static bool AsalMi(int sayi)
        {
            if (sayi < 2)
                return false;
            for (int i = 2; i < sayi; i++)
            {
                if(sayi%i==0)
                {
                    return false;
                }
            }

            return true;

        }

        static int[] DiziOlustur()
        {
            Console.WriteLine("Dizi Boyutu giriniz:");
            int boyut = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[boyut];
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine($"Dizinin {i}. elemanını girin:");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            return dizi;
        }

        static void DiziYazdir(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"Dizinin {i}. elemanı = {a[i]}");
            }
        }

    }
}
