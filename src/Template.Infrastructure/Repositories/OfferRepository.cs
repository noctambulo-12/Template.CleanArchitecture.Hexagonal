using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using Template.Domain.Interfaces;
using Template.Domain.Models.Dto;
using Template.Domain.Models.Entities;
using Template.Infrastructure.Context;

namespace Template.Infrastructure.Repositories
{
    public class OfferRepository : ICustomRepository<Product, int, ProductResult, ProductComponentResult>
    {
        private TemplateDBContext _db;

        public OfferRepository(TemplateDBContext db)
        {
            _db = db;
        }
        public List<Product> GetList()
        {
            return _db.Products.ToList();
        }

        public Product GetListById(int entityId)
        {
            return _db.Products.Where(c => c.ProductId == entityId).FirstOrDefault();
        }

        public List<ProductResult> GetListOfChildren(int entityId)
        {
            throw new NotImplementedException();
        }

        public ProductResult GetProductParent(int entityId)
        {
            var selectedProduct = _db.Products.Where(c => c.ProductId == entityId).FirstOrDefault();

            if (selectedProduct == null) return new ProductResult();

            ProductResult productResult = selectedProduct.Adapt<ProductResult>();

            using (var db = new TemplateDBContext())
            {
                var selectedComponents = _db.ProductComponents.Where(c => c.ProductId == entityId);

                var components = selectedComponents.Adapt<List<ProductComponentResult>>();

                productResult.Component = components;
            }

            return productResult;
        }

        public ProductResult SearchByName(string name)
        {
            var selectedProduct = _db.Products.Where(c => c.Name == name).FirstOrDefault();

            if (selectedProduct == null) return new ProductResult();

            ProductResult productResult = selectedProduct.Adapt<ProductResult>();

            using (var db = new TemplateDBContext())
            {
                var selectedComponents = _db.ProductComponents.Where(c => c.ProductId == selectedProduct.ProductId);

                var components = selectedComponents.Adapt<List<ProductComponentResult>>();

                productResult.Component = components;
            }

            return productResult;
        }

        public bool ValidateFields(string document, byte age)
        {
            if (document != null || age > 18)
                return true;
            else
                return false;
        }

      
    }
}
