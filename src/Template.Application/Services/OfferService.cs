using System.Collections.Generic;
using Template.Application.Interfaces;
using Template.Domain.Interfaces;
using Template.Domain.Models.Dto;
using Template.Domain.Models.Entities;


namespace Template.Application.Services
{
    public class OfferService : ICustomService<Product, int, ProductResult, ProductComponentResult>
    {
        private readonly ICustomRepository<Product, int, ProductResult, ProductComponentResult> _repository;

        public OfferService(ICustomRepository<Product, int, ProductResult, ProductComponentResult> repository)
        {
            _repository = repository;
        }

        public List<Product> GetList()
        {
            return _repository.GetList();
        }

        public Product GetListById(int entityId)
        {
            return _repository.GetListById(entityId);
        }

        public List<ProductResult> GetListOfChildren(int entityId)
        {
            return _repository.GetListOfChildren(entityId);
        }

        public ProductResult GetProductParent(int entityId)
        {
            return _repository.GetProductParent(entityId);
        }

        public ProductResult SearchByName(string name)
        {
            return _repository.SearchByName(name);
        }

        public bool ValidateFields(string document, byte age)
        {
           return _repository.ValidateFields(document, age);
            
        }
    }
}
