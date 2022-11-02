using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TestExcelbd.Repository.Models
{
    public class CustomerAddress
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
       
        public string CustomerAddressDetails { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

    }
}
