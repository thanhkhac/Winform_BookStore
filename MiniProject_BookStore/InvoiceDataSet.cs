﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject_BookStore
{
    [Serializable]
    public class InvoiceDataSet
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
        public string Total { get; set; }


        public InvoiceDataSet()
        {

        }
    }
}
