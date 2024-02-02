using eShopAEXM.Application.IRepository;
using eShopAEXM.Data.Context;
using eShopAEXM.Data.Entities;
using eShopAEXM.ModelView.Enum;
using eShopAEXM.ModelView.ProductVM;
using Microsoft.EntityFrameworkCore;

namespace eShopAEXM.Application.Repository
{
    public class ProductRepo : IProductRepo
    {
        private readonly eShopAEXMContext _eShopAEXMContext;

        public ProductRepo(eShopAEXMContext eShopAEXMContext)
        {
            _eShopAEXMContext = eShopAEXMContext;
        }
        public async Task<ProductDTO> CreateProduct(CreateProductRequest request)
        {
            var product = new Products()
            {
                Id = Guid.NewGuid(),
                BrandID = request.BrandID,
                Name = request.Name,
                CateID = request.CateID,
                Description = request.Description,
                Price = request.Price,
                Status = Status.Active,
            };
            await _eShopAEXMContext.Products.AddAsync(product);
            if (!string.IsNullOrEmpty(request.Url1))
            {
                var productImg = new ProductsIMG()
                {
                    ID = Guid.NewGuid(),
                    Order = 1,
                    ProductID = product.Id,
                    URL = request.Url1,
                };
                _eShopAEXMContext.ProductsIMGs.Add(productImg);
            }
            if (!string.IsNullOrEmpty(request.Url2))
            {
                var productImg = new ProductsIMG()
                {
                    ID = Guid.NewGuid(),
                    Order = 2,
                    ProductID = product.Id,
                    URL = request.Url2,
                };
                _eShopAEXMContext.ProductsIMGs.Add(productImg);
            }
            if (!string.IsNullOrEmpty(request.Url3))
            {
                var productImg = new ProductsIMG()
                {
                    ID = Guid.NewGuid(),
                    Order = 3,
                    ProductID = product.Id,
                    URL = request.Url3,
                };
                _eShopAEXMContext.ProductsIMGs.Add(productImg);
            }
            await _eShopAEXMContext.SaveChangesAsync();
            return await GetProductByID(product.Id);
        }

        public async Task<ProductDTO> GetProductByID(Guid id)
        {

            var product = await _eShopAEXMContext.Products.FirstOrDefaultAsync(x => x.Id == id);
            var productDTO = new ProductDTO();
            if (product != null)
            {
                productDTO = new ProductDTO()
                {
                    Id = product.Id,
                    Name = product.Name,
                    BrandID = product.BrandID,
                    CateID = product.CateID,
                    Description = product.Description,
                    Price = product.Price,
                    Status = product.Status,

                };
                var mainIMG = await _eShopAEXMContext.ProductsIMGs.FirstAsync(x => x.ProductID == product.Id && x.Order == 1);
                productDTO.UrlIMG = mainIMG.URL;

                var brandName = await _eShopAEXMContext.Brands.FirstAsync(x => x.ID == product.BrandID);
                productDTO.BrandName = brandName.Name;

                var proCategory = await _eShopAEXMContext.Categories.FirstAsync(x => x.Id == product.CateID);
                productDTO.CateName = proCategory.Name;
            }

            return productDTO;
        }

        public async Task<List<ProductDTO>> GetProductsWithPagingnation(GetProductWithPagingRequest request)
        {
            var lstProduct = await _eShopAEXMContext.Products.Include(p => p.Brands).Include(p => p.Category).Include(p => p.ProductsIMGs)
                .Where(x => x.Status == Status.Active).OrderBy(p => p.Id).Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize).ToListAsync();
            var lstProductDTO = lstProduct.Select(x => new ProductDTO()
            {
                Id = x.Id,
                Name = x.Name,
                BrandID = x.BrandID,
                BrandName = x.Brands.Name,
                CateID = x.CateID,
                CateName = x.Category.Name,
                Description = x.Description,
                Price = x.Price,
                Status = x.Status,
                UrlIMG = x.ProductsIMGs.Count > 0 ? x.ProductsIMGs.OrderBy(x => x.Order == 1).First().URL : "chưa có ảnh"
            }); ;
            return lstProductDTO.ToList();


        }
    }
}
