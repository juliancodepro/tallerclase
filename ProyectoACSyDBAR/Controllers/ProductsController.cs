using Microsoft.AspNetCore.Mvc;
using ProyectoACSyDBAR.Data.Models;
using ProyectoACSyDBAR.Data.Repository.Interfaces;
using ProyectoACSyDBAR.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoACSyDBAR.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        { 
            _productRepository = productRepository;
        }

        //// GET: api/<ProductsController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<ProductsController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<ProductsController>
        [HttpPost]
        public IActionResult Post([FromBody] CreateProductDTO request)
        {
            var newProduct = new Producto
            {
                Name = request.Name,
                Description = request.Description,
                Price = request.Price,
                Stock = request.Stock,
                Category = request.Category

            };

            _productRepository.CreateProductoAsync(newProduct).Wait();
            
            return Ok(true);
    }
        }

        //// PUT api/<ProductsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ProductsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }

