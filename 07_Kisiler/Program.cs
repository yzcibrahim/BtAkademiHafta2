using System;

namespace _07_Kisiler
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("KİŞİ!!!");

            int kisiIndex = 0;
            Kisi[] kisiler = new Kisi[5];
            
            while (true)
            {
                Kisi k = new Kisi();
                Console.WriteLine(@"Kişi oluşturmak için A Kişiyi yazdırmak için W giriniz Kişilerin yaşlarını 
 yazdırmak için Y, kişi Düzenlemek için D silmek için S, kişi bulmak için B, arama yapmak için 'ARA'  , sıralamak için O giriniz: ");
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
                else if (islem.ToUpper() == "O")
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if (kisiler[j].Yas > kisiler[j + 1].Yas)
                            {
                                Kisi temp = kisiler[j];
                                kisiler[j] = kisiler[j + 1];
                                kisiler[j + 1] = temp;


                            }
                        }
                    }
                }
                else if (islem.ToUpper() == "ARA")
                {
                    Console.WriteLine("Aranacak kelime giriniz:");
                    string aranacakKelime = Console.ReadLine();

                    for (int i = 0; i < kisiler.Length; i++)
                    {
                        if (kisiler[i].Ad.ToUpper() == aranacakKelime.ToUpper() || kisiler[i].Soyad.ToUpper()==aranacakKelime.ToUpper())
                        {
                            Console.WriteLine(kisiler[i].Yazdir());
                        }
                        //if (kisiler[i].Ad.ToUpper().Contains(aranacakKelime.ToUpper()) || kisiler[i].Soyad.ToUpper().StartsWith(aranacakKelime.ToUpper()))
                        //{
                        //    Console.WriteLine(kisiler[i].Yazdir());
                        //}
                        if (kisiler[i].Ad.ToUpper().EndsWith(aranacakKelime.ToUpper()) || kisiler[i].Soyad.ToUpper() == aranacakKelime.ToUpper())
                        {
                            Console.WriteLine(kisiler[i].Yazdir());
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

