using System;

namespace _03_LoopArray
{
    class Program
    {
        static void Main(string[] args)
        {
            #region alıştırmalar
            //KareleriYazdir(10, 15);

            //int[] dizi = DiziIntOku();
            //int toplam = DiziToplami(dizi);

            //int carpim = DiziCarpim(dizi);

            //Console.WriteLine($"dizi toplamı={toplam}");
            //Console.WriteLine($"dizi çarpımı={carpim}");

            //int teklerToplami = TeklerToplami(dizi);
            //Console.WriteLine($"dizi tekler toplamı={teklerToplami}");
            //Console.WriteLine($"dizi çiftler toplamı={CiftlerToplami(dizi)}");
            #endregion
            #region out ref
            //int sayi=5;
            //int asd;
            //KareKup(ref sayi, out asd);
            #endregion

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    continue;

                if (i == 8)
                    break;
                Console.WriteLine(i);
            }

        }
        static void KareKup(ref int a,out int kup)
        {
            kup = a * a * a;
            a = a * a;
        }
        static void KareleriYazdir(int baslangic,int bitis=20)
        {
            for (int i = baslangic; i <= bitis; i++)
            {
                Console.WriteLine($"{i} sayısının karesi {i * i}");
            }
        }
        static int TeklerToplami(int[] a)
        {
            int teklerToplam = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 1)
                {
                    teklerToplam += a[i];
                }
            }

            return teklerToplam;
        }

        static int CiftlerToplami(int[] a)
        {
            int toplam = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    toplam += a[i];
                }
            }
            return toplam;
        }
        static int DiziCarpim(int[] dizi)
        {
            int carpim = 1;
            for (int i = 0; i < dizi.Length; i++)
            {
                // carpim = carpim * dizi[i];
                carpim *= dizi[i];
            }
            return carpim;
        }
        static int DiziToplami(int[] a)
        {
            int toplam = 0;
            for (int i = 0; i < a.Length; i++)
            {
                //toplam = toplam + a[i];
                toplam += a[i];
            }

            return toplam;
        }
        static int[] DiziIntOku()
        {
            int boyut = IntOku("Dizinin Boyutunu Giriniz:");
            int[] dizi = new int[boyut];

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = IntOku($"dizinin {i}. elemanını giriniz");
            }
            return dizi;
        }
        static int IntOku(string mesaj)
        {
            Console.WriteLine(mesaj);
            return Convert.ToInt32(Console.ReadLine());
        }
        static void LoopSyntax()
        {
            string soyad = "yazıcı";
            string result = "ibrahim" + soyad + " merhaba";
            result = String.Format($"ibrahim {soyad} merhaba");
            //i=i+1
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + ".Hello word");
            }

            int index = 0;
            while (index < 10)
            {
                Console.WriteLine(index + ".Hello word");
                //index=index+1
                //index += 1;
                index++;
            }

            do
            {
                Console.WriteLine("Do while çalıştı");
            }
            while (index < 10);


            //for,while, dowhile
        }


    }
}
