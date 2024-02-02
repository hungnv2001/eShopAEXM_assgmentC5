using eShopAEXM.Application.IRepository;
using eShopAEXM.ModelView.ProductVM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace eShopAEXM.backEndApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepo _productRepo;

        public ProductController(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }
        [HttpPost("getlstProductWithPading")]
        public async Task<ActionResult> GetProductWithPaging(GetProductWithPagingRequest request)
        {
            var products = await _productRepo.GetProductsWithPagingnation(request);
            return Ok(products);
        } 
        
    }
}
