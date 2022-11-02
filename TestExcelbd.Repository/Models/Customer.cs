using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TestExcelbd.Repository.Models
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ForeignKey("Country")]
        [Key]
        public int ID { get; set; }
   
        public string CustomerName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public int MaritalStatus { get; set; }
        public byte[] CustomerPhoto { get; set; }

        //  public virtual Country Country { get; set; }

       // public int CustomerId { get; set; }
        public ICollection<CustomerAddress> CustomerAddress { get; set; }

        public Country Country { get; set; }
        public int CountryId { get; set; }


    }
}
