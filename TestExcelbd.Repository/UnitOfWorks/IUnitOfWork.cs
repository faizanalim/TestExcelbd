using System;
using System.Collections.Generic;
using System.Text;
using TestExcelbd.Repository.Models;
using TestExcelbd.Repository.Repositories;

namespace TestExcelbd.Repository.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customer { get; }
        int Complete();
    }
}
