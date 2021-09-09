using System;

namespace Template.Domain.Models.Entities
{
    public class ProductComponent
    {
        public int ProductComponentId { get; set; }
        public int ProductId { get; set; }
        public string ProductType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool IsItSoldOut { get; set; }
        public int CreationUserId { get; set; }
        public int ModificationUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }

    }
}