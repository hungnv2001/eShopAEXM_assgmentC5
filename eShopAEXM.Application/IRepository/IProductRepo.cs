using eShopAEXM.ModelView.ProductVM;

namespace eShopAEXM.Application.IRepository
{
    public interface IProductRepo
    {
        Task<ProductDTO> CreateProduct(CreateProductRequest request);
        Task<ProductDTO> GetProductByID(Guid id);
        Task<List<ProductDTO>> GetProductsWithPagingnation(GetProductWithPagingRequest request);
    }
}
