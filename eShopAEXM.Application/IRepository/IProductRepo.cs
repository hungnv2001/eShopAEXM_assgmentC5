using eShopAEXM.ModelView.ProductVM;

namespace eShopAEXM.Application.IRepository
{
    public interface IProductRepo
    {
        Task<ProductDTO> CreateProduct(CreateProductRequest request);
        Task<ProductDTO> GetProductByID(Guid id);

		Task<ProductShopListPaging> GetProductsWithPagingnation(GetProductWithPagingRequest request);


        Task<ProductDetailsVM> DetailsVM(Guid? id);

    }
}
