﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_SampleImplementation
{
    internal class CustomerModel : ICustomerModel
    {
        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public string Adres { get; set; }
        public string Sehir { get; set; }
        public string EmailAdres { get; set; }
        public string TelefonNumarasi { get; set; }
    }
}
