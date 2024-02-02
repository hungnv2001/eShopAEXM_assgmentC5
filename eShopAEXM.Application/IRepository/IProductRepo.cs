using eShopAEXM.ModelView.ProductVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopAEXM.Application.IRepository
{
    public interface IProductRepo
    {
        Task<ProductDTO> CreateProduct(CreateProductRequest request);
        Task<ProductDTO> GetProductByID(Guid id);
        Task<List<ProductDTO>> GetProductsWithPagingnation(GetProductWithPagingRequest request);
    }
}
