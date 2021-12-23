using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : EntityBase
    {
        #region Variables

        protected DbContext context;
        protected DbSet<T> dbset;

        #endregion

        #region Conctruct

        public GenericRepository(DbContext dbContext)
        {
            context = dbContext;
            dbset = context.Set<T>();
            context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        #endregion

        #region method

        public T Add(T model)
        {
            context.Entry(model).State = EntityState.Added;
            dbset.Add(model);
            return model;
        }

        public bool Delete(int id)
        {
            return Delete(Find(id));
        }

        public bool Delete(T model)
        {
            if (context.Entry(model).State == EntityState.Deleted)
            {
                context.Attach(model);
            }

            return dbset.Remove(model) != null;

        }

        public T Find(int id)
        {
            return dbset.Find(id);
        }

        public List<T> GetAll()
        {
            return dbset.ToList();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return dbset.Where(expression);
        }

        public T Update(T model)
        {
            dbset.Update(model);

            return model;
        }

        #endregion

    }
}
