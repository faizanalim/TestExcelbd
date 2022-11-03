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

        public void Add(Customer entity)
        {
            _context.Add(entity);

        }

        //public Customer GetById(int id)
        //{ 

        //}
        // public IEnumerable<Customer> GetAll()
        // { 
        //// return _context.Countries.Get
        // }

        public void Remove(Customer entity)
        {


        }
    }
}
