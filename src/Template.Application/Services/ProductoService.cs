using System;
using System.Collections.Generic;
using Template.Application.Interfaces;
using Template.Domain.Interfaces;
using Template.Domain.Models.Entities;

namespace Template.Application.Services
{
    public class ProductoService : IBaseCommandService<Product, int>
    {
        private readonly IBaseCommandRepository<Product, int> _repository;

        public Product Add(Product entity)
        {
            if (entity == null)
                throw new ArgumentNullException("the 'product' is required.");

            var product = _repository.Add(entity);
            _repository.SaveAllChanges();

            return product;
        }

        public void Delete(int entityId)
        {
            _repository.Delete(entityId);
            _repository.SaveAllChanges();
        }

        public void Edit(Product entity)
        {
            if (entity == null)
                throw new ArgumentNullException("the 'product' is required.");

            _repository.Edit(entity);
            _repository.SaveAllChanges();
        }

        public List<Product> GetList()
        {
            return _repository.GetList();
        }

        public Product GetListById(int entityId)
        {
            return _repository.GetListById(entityId);
        }
    }
}
