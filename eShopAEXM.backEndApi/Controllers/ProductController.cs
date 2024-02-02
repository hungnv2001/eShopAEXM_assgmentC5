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
        [HttpPost("getlstProductWithPading")]
        public async Task<ActionResult> GetProductWithPaging(GetProductWithPagingRequest request)
        {
            var products = await _productRepo.GetProductsWithPagingnation(request);
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDetailsVM>> Detail(Guid? id)
        {
            var product = await _productRepo.DetailsVM(id);
            if (product == null)
            {
                return NotFound(); // Trả về mã lỗi 404 nếu không tìm thấy sản phẩm
            }
            return Ok(product);
        }

    }
}
