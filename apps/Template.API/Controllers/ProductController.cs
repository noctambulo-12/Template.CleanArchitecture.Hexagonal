using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Template.Application.Services;
using Template.Infrastructure.Context;
using Template.Infrastructure.Repositories;

namespace Template.API.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class ProductController : ControllerBase
    {
        OfferService CrearServicio()
        {
            TemplateDBContext dbContext = new TemplateDBContext();
            OfferRepository repository = new OfferRepository(dbContext);
            OfferService service = new OfferService(repository);

            return service;
        }

        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{productId}")]
        public IActionResult Get(int productId)
        {
            var service = CrearServicio();
            var products = service.GetProductParent(productId);

            if (products is not null)
                return Ok(products);

            return NotFound(products);

        }
    }
}
