using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompleksTipler
{
    public struct Kisi
    {
        public string Ad;
        public string Soyad;
        public int Yas;
        
        public string Yazdir()
        {
            string yazdirilacak = $"{Ad} {Soyad} {Yas}";
            return yazdirilacak;
        }

    }
}

//public private protected
