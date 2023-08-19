using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IMusteri
    {
        // Field'lar
        int Id { get; set; }
        string Isim { get; set; }
        string SoyIsim { get; set; }

        // Metotlar
        int YeniKayit(string isim, string soyisim);
        int KayitDuzenle(int id, string isim, string soyisim);
        int KayitSil(int id);
    }
}
