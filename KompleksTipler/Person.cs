using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompleksTipler
{
    public class Person
    {
        public string Ad;
        public string Soyad;
        public int Yas;
        public static int Adet = 0;

        public Person()
        {
            Adet++;
        }

        public string Tanim()
        {
            return $"Ad:{Ad} Soyad:{Soyad} Yaş:{Yas}";
        }
        public static void Selamla()
        {
            Console.WriteLine("Merhaba");
        }
    }
}
