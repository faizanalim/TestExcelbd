using System;
using System.Collections.Generic;
using System.Text;

namespace TestExcelbd.Repository.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public int CountryId { get; set; }

        public string CustomerName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public int MaritalStatus { get; set; }
        public byte[] CustomerPhoto { get; set; }

        public ICollection<Country> Countries { get; set; }
    }
}
