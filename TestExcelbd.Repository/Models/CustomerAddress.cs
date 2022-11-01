using System;
using System.Collections.Generic;
using System.Text;

namespace TestExcelbd.Repository.Models
{
    public class CustomerAddress
    {
        public int ID { get; set; }
        public int CustomerId { get; set; }
        public string CustomerAddressDetails { get; set; }

        public ICollection<Customer> Customers { get; set; }

    }
}
