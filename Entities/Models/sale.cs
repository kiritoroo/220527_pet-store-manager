﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class sale
    {
        public int  ID { get; set; }
        public DateTime saledate { get; set; }
        
        public float SaleTax { get; set; }

        public string EmployeeID { get; set; }

        public string CustomerID { get; set; }

        public employee Employee { get; set; }
        public customer Customer { get; set; }
        public ICollection<saleAnimal> SaleAnimals { get; set; }
        public ICollection<saleItem> SaleItems { get; set; }
    }
}
