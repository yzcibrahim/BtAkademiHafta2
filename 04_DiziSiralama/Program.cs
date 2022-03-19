using System;

namespace _04_DiziSiralama
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("dizi boyutu giriniz:");
            //int size = Convert.ToInt32(Console.ReadLine());
            int boyut = IntOku("dizi boyutu giriniz:");
            int[] dizi = new int[boyut];

            for (int i = 0; i < boyut; i++)
            {
                dizi[i] = IntOku("dizinin " + i + ". elemanını giriniz:");
            }

            for (int j = 0; j < dizi.Length; j++)
            {
                int min = dizi[j];
                int minIndex = j;
                for (int i = j; i < dizi.Length; i++)
                {
                    if (min > dizi[i])
                    {
                        min = dizi[i];
                        minIndex = i;
                    }
                }
                int temp = dizi[j];
                dizi[j] = dizi[minIndex];
                dizi[minIndex] = temp;
            }
            
            #region alıştırma
            //Console.WriteLine("sayi1 giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //int sayi1 = IntOku("sayi1 giriniz");
            //int sayi2 = IntOku("sayi2 girini<z");

            //int kucuk = KucukBul(sayi1, sayi2);
            //Console.WriteLine(kucuk);
            #endregion
        }
        static int KucukBul(int a,int b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static int IntOku(string mesaj="Sayı giriniz")
        {
            Console.WriteLine(mesaj);
            int sayi = Convert.ToInt32(Console.ReadLine());
            return sayi;
        }
    }
}
