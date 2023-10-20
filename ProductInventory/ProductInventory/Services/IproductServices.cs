using ProductInventory.Models;

namespace ProductInventory.Services
{
    public interface IproductServices
    {
        Task<AddProductResponse> AddProductToInventory(AddProductRequest request);
        Task<GetAllProductResponse> GetAllProduct();
    }
}
