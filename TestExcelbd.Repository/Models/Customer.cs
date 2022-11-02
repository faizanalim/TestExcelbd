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
   
       // [Key, ForeignKey("Country")]
      //  public int CountryID { get; set; }

        public string CustomerName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public int MaritalStatus { get; set; }
        public byte[] CustomerPhoto { get; set; }

        //  public ICollection<Country> Countries { get; set; }
        public virtual Country Country { get; set; }
    }
}
