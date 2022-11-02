using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestExcelbd.Repository.EF_Code;
using TestExcelbd.Repository.Models;

namespace TestExcelbd.Web.Data
{
    public static class DbInitializer
    {
        public static void Initialize(CustomerContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Countries.Any())
            {
                return;   // DB has been seeded
            }

            var countries = new Country[]
            {
            new Country{CountryName="Malaysia"},
            new Country{CountryName="Singapore"},
            new Country{CountryName="Australia"},
            new Country{CountryName="New Zealand"},
            new Country{CountryName="Canada"},

            };
            foreach (Country s in countries)
            {
                context.Countries.Add(s);
            }
            context.SaveChanges();


        }
    }
}
