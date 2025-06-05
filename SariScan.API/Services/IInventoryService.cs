using SariScan.API.Models.DTOS;

namespace SariScan.API.Services
{
    public interface IInventoryService
    {
        Task<bool> AddProductAsync(ProductDTO product);
        Task<bool> CheckoutProductAsync(CheckoutDTO checkout);
        Task<ProductDTO?> GetProductByBarcodeAsync(string barcode);
        Task<IEnumerable<ProductDTO>> GetAllProductAsync();
    }
}