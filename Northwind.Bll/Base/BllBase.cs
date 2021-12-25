using Northwind.Dal.Abstract;
using Northwind.Entity.Base;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Entity.IBase;
using AutoMapper;

namespace Northwind.Bll.Base
{
    class BllBase<T, TDto> : IGenericService<T, TDto> where T : EntityBase where TDto : DtoBase
    {
        #region Variables
        private readonly IUnitOfWork unitOfWork;
        private readonly IServiceProvider service;
        private readonly IGenericRepository<T> repository;
        Mapper mapper;
        public BllBase(IServiceProvider service)
        {
            unitOfWork = service.GetService<IUnitOfWork>();
            repository = unitOfWork.GetRepository<T>();
            this.service = service;
        }
     
        #endregion

        public IResponse<TDto> Add(TDto item, bool saveChanges = true)
        {
            try
            {
                var resolvedResult = "";
                var Tresult = repository.Add(mapper.Map<T>(item));
                resolvedResult = String.Join(',', Tresult.GetType().GetProperties().Select(x => $" - {x.Name}"));
                if (saveChanges)
                    Save();
                
                return new Response<TDto>
                {
                    StatusCode = 100,
                    Message = "Success",
                    Data = mapper.Map<T, TDto>(Tresult)
                };
            }
            catch (Exception ex)
            {
                return new Response<TDto>
                {
                    StatusCode = 200,
                    Message = "Error:",
                    Data = null
                };

            }

        }

        public Task<TDto> AddAsync(TDto model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TDto model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(TDto model)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public TDto Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<TDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<TDto> GetAll(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TDto> GetIQueryable()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            unitOfWork.SaveChanges();
        }

        public TDto Update(TDto model)
        {
            throw new NotImplementedException();
        }

        public Task<TDto> UpdateAsync(TDto model)
        {
            throw new NotImplementedException();
        }

        IResponse<TDto> IGenericService<T, TDto>.Add(TDto item)
        {
            throw new NotImplementedException();
        }
    }
}
