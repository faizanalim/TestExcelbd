using System;
using System.Collections.Generic;
using System.Text;
using TestExcelbd.Repository.EF_Code;
using TestExcelbd.Repository.Repositories;

namespace TestExcelbd.Repository.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CustomerContext _context;
        public UnitOfWork(CustomerContext context)
        {
            _context = context;
            Customer = new CustomerRepository(_context);

        }
        public ICustomerRepository Customer { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
