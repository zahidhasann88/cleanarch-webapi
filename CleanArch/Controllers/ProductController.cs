using CleanArch.Infracture.Services.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _productServices;
        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }
        //[Authorize]
        [HttpGet("GetProduct")]
        public async Task<IActionResult> GetProduct()
        {
            try
            {
                var data = await _productServices.GetAllProduct();
                if (data.Count != 0)
                {
                    return Ok(data);
                }
                else
                {
                    return Ok("null");
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
