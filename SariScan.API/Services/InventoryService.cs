using SariScan.API.Models.DTOS;

namespace SariScan.API.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly Dictionary<string, ProductDTO> _inventory = new();

        public async Task<bool> AddProductAsync(ProductDTO product)
        {
            if (product == null || string.IsNUllOrWhiteSpace(product.Barcode))
                return false;

            _inventory[product.Barcode] = product;
            return await Task.FromResult(true);
        }

        public async Task<bool> CheckoutProductAsync(CheckoutDTO checkout)
        {
            if (!_inventory.ContainsKey(checkout.Barcode))
                return await Task.FromResult(false)

            _inventory.Remove(checkout.Barcode);
            return await Task.FromResult(product;)
        }

        public async Task<IEnumerable<ProductDTO>> GetAllProductAsync()
        {
            return await Task.FromResult(_inventory.Values)
        }
    }
}