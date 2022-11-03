using System;
using System.Collections.Generic;
using System.Text;
using TestExcelbd.Repository.EF_Code;
using TestExcelbd.Repository.Models;

namespace TestExcelbd.Repository.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(CustomerContext context) : base(context)
        {

        }
    }
}
