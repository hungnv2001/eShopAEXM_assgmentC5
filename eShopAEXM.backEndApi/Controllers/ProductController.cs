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
        [HttpGet]
        public Task<List<ProductDTO>> GetProductWithPaging(GetProductWithPagingRequest request)
        {
            return _productRepo.GetProductsWithPagingnation(request);
        }
    }
}
