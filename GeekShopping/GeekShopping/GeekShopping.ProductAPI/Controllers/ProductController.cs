using GeekShopping.ProductAPI.DTO;
using GeekShopping.ProductAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductAPI.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetAll()
        {
            var products = await _repository.GetAll();
            if (products == null) 
                return NotFound();
            return Ok(products);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<ProductDTO>> Get(int id)
        {
            var product = await _repository.GetById(id);
            if (product.Id <= 0)
                return NotFound();
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ProductDTO product)
        {
            if (product == null)
                return BadRequest();

            var createdProduct = await _repository.Create(product);
            return Ok(createdProduct);

        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] ProductDTO product)
        {
            if (product == null)
                return BadRequest();

            var updatedProduct = await _repository.Update(product);
            return Ok(updatedProduct);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var response = await _repository.Delete(id);

            if (!response)
                return NotFound();
            else
                return Ok(response);    
        }
    }
}
