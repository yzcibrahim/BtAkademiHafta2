using System;

namespace _07_Kisiler
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi yeniKis = new Kisi();
            yeniKis.Test = 15;
            yeniKis.Ad = "ibrahim";
            yeniKis.Soyad = "yazıcı";
            Console.WriteLine(yeniKis.TamAd);
            Console.WriteLine(yeniKis.Test);

            Console.WriteLine("KİŞİ!!!");

            int kisiIndex = 0;
            Kisi[] kisiler = new Kisi[5];
            
            while (true)
            {
                Kisi k = new Kisi();
                Console.WriteLine(@"Kişi oluşturmak için A Kişiyi yazdırmak için W giriniz Kişilerin yaşlarını 
 yazdırmak için Y, kişi Düzenlemek için D silmek için S, kişi bulmak için B giriniz:");
                string islem = Console.ReadLine();

                if (islem.ToUpper() == "A")
                {
                    k = KisiOlustur();
                    kisiler[kisiIndex] = k;
                    kisiIndex++;
                }
                else if (islem.ToUpper() == "W")
                {
                    for (int i = 0; i < kisiIndex; i++)
                    {
                        if (kisiler[i] != null)
                            Console.WriteLine(kisiler[i].Yazdir());
                    }
                }
                else if (islem.ToUpper() == "Y")
                {
                    for (int i = 0; i < kisiIndex; i++)
                    {
                        if (kisiler[i] != null)
                            Console.WriteLine(kisiler[i].Yas);
                    }
                }
                else if (islem.ToUpper() == "D")
                {
                    Console.WriteLine("Kaçıncı kişi ve kişinin yeni ad soyad doğum yılı bilgilerini giriniz");
                    string girilenDeger = Console.ReadLine();
                    //0 deneme test 2000
                    string[] degerlerDizi = girilenDeger.Split(" ");

                    int duzenlencekIndex = Convert.ToInt32(degerlerDizi[0]);
                    Console.WriteLine(kisiler[duzenlencekIndex].Yazdir() + " kişisi düzenlenecek emin misiniz E/H");
                    string secim = Console.ReadLine();
                    if (secim == "E")
                    {
                        kisiler[duzenlencekIndex].Ad = degerlerDizi[1];
                        kisiler[duzenlencekIndex].Soyad = degerlerDizi[2];
                        kisiler[duzenlencekIndex].DogumYil = Convert.ToInt32(degerlerDizi[3]);
                    }

                }
                else if (islem.ToUpper() == "S")
                {
                    int silinecekIndex;
                    Console.WriteLine("Silincek indexi giriniz[0-4]");
                    silinecekIndex = Convert.ToInt32(Console.ReadLine());
                    kisiler[silinecekIndex] = null;
                }
                else if (islem == "B")
                {
                    Console.WriteLine("Aranacak kişi ismi giriniz");
                    string aranacak = Console.ReadLine();
                    for (int i = 0; i < kisiler.Length; i++)
                    {
                        if (kisiler[i] == null)
                            continue;
                        if (kisiler[i].Ad == aranacak)
                        {
                            Console.WriteLine(kisiler[i].Yazdir());
                            break;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Tanımalnamayan işlem girişi");
                }
            }
        }
        static Kisi KisiOlustur()
        {
            Kisi kisi = new Kisi();
            Console.WriteLine("Kişinin ad soyad doğum yılını aralarda boşluk olacak şekilde giriniz:");
            string girilenDeger = Console.ReadLine();
            string[] degerler = girilenDeger.Split(" ");
            kisi.Ad = degerler[0];
            kisi.Soyad = degerler[1];
            kisi.DogumYil = Convert.ToInt32(degerler[2]);
            
            return kisi;
        }
    }
}

