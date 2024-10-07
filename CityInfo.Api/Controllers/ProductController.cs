using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Api.Controllers
{
    // productController

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
 [HttpGet]
 public async Task<IActionResult> GetAll()
 {
     var product = await _productService.GetAllProducts();
     return Ok(product);
 }

 [HttpPost]
 public async Task<IActionResult> Add([FromBody] Product product)
 {
     var result =await _productService.AddProduct(product);
     return Ok(result);
 }

 [HttpGet("{id}")]
 public async Task<IActionResult> GetById(int id)
 {
     var product = await _productService.GetProductById(id);
     return Ok(product);
 }

 [HttpPut("{id}")]
 public async Task<IActionResult> Update(int id, [FromBody] Product product)
 {
     if (id != product.ProductId) return BadRequest();
   var result =  await _productService.UpdateProduct(product);
     return Ok(result);

 }

 [HttpDelete("{id}")]      
 public async Task<IActionResult> Delete(int id)
 {
   var result=  await _productService.DeleteProduct(id);
     return Ok(result);
 }

    }
}
