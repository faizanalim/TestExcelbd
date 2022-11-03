using System;
using System.Collections.Generic;
using System.Text;
using TestExcelbd.Repository.Models;

namespace TestExcelbd.Repository.Repositories
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        Customer GetById(int id);
        IEnumerable<Customer> GetAll();
        public void Add(Customer entity);
        void Remove(Customer entity);
    }
}
