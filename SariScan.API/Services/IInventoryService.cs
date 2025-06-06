using SariScan.API.Models.DTOS;

namespace SariScan.API.Services
{
    public interface IInventoryService
    {
        Task<ProductDTO> AddProduct(ProductDTO product);
        Task<ProductDTO> UpdateProduct(ProductDTO product);
        Task DeleteProduct(string barcode);
        Task<bool> CheckoutProduct(CheckoutDTO checkout);
        Task<ProductDTO?> GetProductByBarcode(string barcode);
        Task<IEnumerable<ProductDTO>> GetAllProducts();
    }
}