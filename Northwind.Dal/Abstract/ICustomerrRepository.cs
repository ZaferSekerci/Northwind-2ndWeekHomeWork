using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Abstract
{
    public interface ICustomerrRepository : IGenericRepository<Customer>
    {
        IQueryable CustomerReport();
    }
}
