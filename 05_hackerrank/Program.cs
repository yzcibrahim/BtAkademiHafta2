using System;

namespace _05_hackerrank
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Soru0();

            // Soru1();

            // Soru2();

            while (true)
            {
                Soru3();
            }
        }

        static void Soru1()
        {
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sayi1 + sayi2);
        }

        static void Soru3()
        {
            Console.WriteLine("soru3 çalışıyor");
            string[] strDizi = Console.ReadLine().Split(" ");
            int[] diziAlice = Array.ConvertAll<string,int>(strDizi, element => Convert.ToInt32(element));

            int[] diziBob = Array.ConvertAll<string, int>(Console.ReadLine().Split(" "), element => Convert.ToInt32(element));

            int alice = 0;
            int bob = 0;
            
            for (int i = 0; i < diziAlice.Length; i++)
            {
                if (diziAlice[i] > diziBob[i])
                {
                    alice++;
                }
                else if (diziAlice[i] < diziBob[i])
                {
                    bob++;
                }
                else
                {
                    
                }
            }
            Console.WriteLine($"{alice} {bob}");
        }

        /// <summary>
        /// girilen dizinin eleman değerlerinin toplamı
        /// </summary>
        static void Soru2()
        {
            Console.WriteLine("dizinin elemanlarını aralarda boşluk olarak giriniz");
            string girilenDeger = Console.ReadLine();
            string[] strDiz = girilenDeger.Split(" ");
            int[] dizi = new int[strDiz.Length];
            for(int i=0;i<strDiz.Length;i++)
            {
                int sayi = Convert.ToInt32(strDiz[i]);
                dizi[i] = sayi;
            }
            int toplam = 0;
            for(int i=0;i<dizi.Length;i++)
            {
                toplam += dizi[i];
            }
            Console.WriteLine(toplam);

        }
        static void Soru0()
        {
            Console.WriteLine("Dizi boyutu girin:");
            int boyut = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[boyut];

            for (int i = 0; i < boyut; i++)
            {
                Console.WriteLine($"dizinin {i}. elemanını giriniz:");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            int diziMaxEleman = MaxBul(dizi);

            int[] diziElemanCount = new int[diziMaxEleman + 1];

            for (int i = 0; i < dizi.Length; i++)
            {
                int tekrarEdenSAyi = dizi[i];
                diziElemanCount[tekrarEdenSAyi]++;
            }

            int max = diziElemanCount[0];
            int maxIndex = 0;
            for (int i = 0; i < diziElemanCount.Length; i++)
            {
                if (diziElemanCount[i] > max)
                {
                    max = diziElemanCount[i];
                    maxIndex = i;
                }
            }

            Console.WriteLine(maxIndex);
        }

        static int MaxBul(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }
            return max;
        }
    }
}
