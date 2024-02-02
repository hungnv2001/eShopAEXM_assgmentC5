using eShopAEXM.Application.IRepository;
using eShopAEXM.ModelView.ProductVM;
using Microsoft.AspNetCore.Mvc;

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
        [HttpPost]
        public async Task<ActionResult> GetProductWithPaging(GetProductWithPagingRequest request)
        {
            var products = await _productRepo.GetProductsWithPagingnation(request);
            return Ok(products);
        }

    }
}
