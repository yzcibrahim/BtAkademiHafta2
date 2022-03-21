using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Kisiler
{
    public class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYil { get; set; }
        public int Yas
        {
            get
            {
                return DateTime.Today.Year - DogumYil;
            }
        }

        public string TamAd
        {
            get
            {
                return $"{Ad} {Soyad}";
            }
        }

        private int _test;
        public int Test
        {
            get { return _test; }
            set { _test = value*2; }
        }
        public string Yazdir()
        {
           // Yas = DateTime.Today.Year - DogumYil;
            return $"{Ad} {Soyad} {Yas}";
        }
    }
}
