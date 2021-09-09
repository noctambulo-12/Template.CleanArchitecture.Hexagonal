using System;
using System.Collections.Generic;
using System.Linq;
using Template.Domain.Interfaces;
using Template.Domain.Models.Entities;
using Template.Infrastructure.Context;

namespace Template.Infrastructure.Repositories
{
    public class ProductRepository : IBaseCommandRepository<Product, int>
    {
        private TemplateDBContext _db;

        public ProductRepository(TemplateDBContext db)
        {
            _db = db;
        }

        public Product Add(Product entity)
        {
            _db.Products.Add(entity);

            return entity;
        }

        public void Delete(int entityId)
        {
            var selectedProduct = _db.Products.Where(c => c.ProductId == entityId).FirstOrDefault();

            if (selectedProduct != null)
            {
                _db.Remove(selectedProduct);
            }
        }

        public void Edit(Product entity)
        {
            var selectedProduct = _db.Products.Where(c => c.ProductId == entity.ProductId).FirstOrDefault();

            if (selectedProduct != null)
            {
                selectedProduct.Name = entity.Name;
                selectedProduct.Price = entity.Price;
                selectedProduct.ModificationDate = DateTime.UtcNow;
            }

            _db.Entry(selectedProduct).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public List<Product> GetList()
        {
            return _db.Products.ToList();
        }

        public Product GetListById(int entityId)
        {
            return  _db.Products.Where(c => c.ProductId == entityId).FirstOrDefault();
        }

        public void SaveAllChanges()
        {
            _db.SaveChanges();
        }
    }
}
