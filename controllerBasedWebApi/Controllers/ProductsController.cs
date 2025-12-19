using AutoMapper;
using controllerBasedWebApi.Data.DTOs;
using controllerBasedWebApi.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace controllerBasedWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IMapper _mapper;

        public ProductsController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            Product[] products =
            {
                new Product { Id = 1, Name = "Product A", Price = 10.0M },
                new Product { Id = 2, Name = "Product B", Price = 20.0M },
                new Product { Id = 3, Name = "Product C", Price = 30.0M }
            };
            
            var productsDto = _mapper.Map<ProductDTO[]>(products);


            return Ok(productsDto);
        }
    }
}
