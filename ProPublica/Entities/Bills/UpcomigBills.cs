﻿using ProPublica.Entities.Bills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProPublica.Entities.Bills
{
    public class UpcomingBills
    {
        public string date { get; set; }
        public List<UpcomingBill> bills { get; set; }
    }
}
