﻿using PostorderCompany.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostorderCompany.Core.Commands
{
    public class Pakket
    {
        public string orderId;
        public Persoonsgegevens afzender;
        public Persoonsgegevens ontvanger;
        public string gewicht;
        public string afmetingen;
    }
}
