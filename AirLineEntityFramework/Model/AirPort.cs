﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineEntityFramework.Model
{
    internal class AirPort
    {
        public int ID { get; set; }
        public string AirPortName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
