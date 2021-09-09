using System.Collections.Generic;

namespace Template.Domain.Models.Dto
{
    public class ProductResult
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Stock { get; set; }
        public List<ProductComponentResult> Component { get; set; }
    }
}
