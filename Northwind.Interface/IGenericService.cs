using Northwind.Entity.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Interface
{
    public interface IGenericService<T, TDto> where T : IEntityBase where TDto : IDtoBase
    {
        List<TDto> GetAll();
        List<TDto> GetAll(Expression<Func<T, bool>> expression);
        TDto Find(int id);
        IQueryable<TDto> GetIQueryable();
        TDto Add(TDto model);
        Task<TDto> AddAsync(TDto model);
        TDto Update(TDto model);
        Task<TDto> UpdateAsync(TDto model);
        bool DeleteById(int id);
        Task<bool> DeleteByIdAsync(int id);
        bool Delete(TDto model);
        Task<bool> DeleteAsync(TDto model);


    }
}
