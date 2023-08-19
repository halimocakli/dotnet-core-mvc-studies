using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Musteri : IMusteri
    {
        private int id;
        private string isim;
        private string soyisim;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }

        public string SoyIsim
        {
            get { return soyisim; }
            set { soyisim = value; }
        }

        public int YeniKayit(string isim, string soyisim)
        {
            Console.WriteLine("YeniKayit() metodu çalıştı.");
            return 1;
        }

        public int KayitDuzenle(int id, string isim, string soyisim)
        {
            Console.WriteLine("KayitDuzenle() metodu çalıştı.");
            return 1;
        }

        public int KayitSil(int id)
        {
            Console.WriteLine("KayitSil() metodu çalıştı.");
            return 1;
        }
    }
}
