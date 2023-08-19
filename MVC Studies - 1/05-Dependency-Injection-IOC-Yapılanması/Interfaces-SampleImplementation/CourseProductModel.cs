﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_SampleImplementation
{
    internal class CourseProductModel : IProductModel
    {
        public string UrunAdi { get; set; }
        public bool SiparisGerceklesmeKontrol { get; private set; }
        public void UrunSevk(CustomerModel musteri)
        {
            if (SiparisGerceklesmeKontrol == false)
            {
                Console.WriteLine($"{UrunAdi} eğitimi {musteri.Isim} isimli müşteri hesabına eklendi.");
                SiparisGerceklesmeKontrol = true;
            }
        }
    }
}
