namespace Template.Domain.Models.Dto
{
    public class ProductComponentResult
    {
        public int ProductComponentId { get; set; }
        public string ProductType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool IsItSoldOut { get; set; }

    }
}
