using eShopAEXM.Application.IRepository;
using eShopAEXM.Data.Context;
using eShopAEXM.Data.Entities;
using eShopAEXM.ModelView.Enum;
using eShopAEXM.ModelView.ProductVM;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;

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


        public async Task<ProductDetailsVM> DetailsVM(Guid? id)
        {
            //check
            if (id == null)
            {
                // return cannot find product
                return null;
            }
            //Find product id == id
            var product = await _eShopAEXMContext.Products.Include(p => p.ProductVariants)
                .ThenInclude(v => v.Size)
                .Include(p => p.ProductVariants)
                 .ThenInclude(v => v.Color)
                   .Include(p => p.ProductsIMGs)
                   .FirstOrDefaultAsync(g => g.Id == id);

            //foreach (var variant in DataVariants)
            //{
            //    variant.Size = _eShopAEXMContext.Sizes.FirstOrDefault(m => m.ID == variant.Id);
            //    variant.Color = _eShopAEXMContext.Colors.FirstOrDefault(m => m.ID == variant.Id);
            //}
            //product.ProductVariants = DataVariants;

            //return productVM
            var productVM = new ProductDetailsVM()
            {
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                //Sizes = product.ProductVariants.Select(v => v.Size).ToList(),
                //Colors = product.ProductVariants.Select(v => v.Color).ToList(),
                Imgs = product.ProductsIMGs.Select(img => img.URL).ToList()
            };

            return productVM;

        }

        public async Task<ProductShopListPaging> GetProductsWithPagingnation(GetProductWithPagingRequest request)
        {
            var lstProduct = await _eShopAEXMContext.Products.Include(p => p.Brands).Include(p => p.Category).Include(p=>p.ProductsIMGs).Include(p=>p.ProductVariants)
                .Where(p => p.ProductVariants.Any(p => p.Quantity > 0 && p.Status == Status.Active)&&p.Status==Status.Active).OrderBy(p => p.Id).ToListAsync();

            var pages = (int)Math.Ceiling(lstProduct.Count() / (double)request.PageSize);

            lstProduct = lstProduct.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize).ToList();
            

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
                UrlIMG = x.ProductsIMGs.Count>0 ? x.ProductsIMGs.OrderBy(x => x.Order == 1).First().URL : "chưa có ảnh"
            }); ;
          
            return  new ProductShopListPaging()
            { 
                PageIndex = request.PageIndex,
                PageSize = lstProductDTO.Count(),
                Data  =lstProductDTO.ToList(),
                TotalPage= pages,
            };
                


        }

      
    }
}
