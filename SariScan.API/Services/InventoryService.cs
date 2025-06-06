using SariScan.API.Models.DTOS;

namespace SariScan.API.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly Dictionary<string, ProductDTO> _inventory = new();

        public async Task<bool> AddProduct(ProductDTO product)
        {
            if (product == null || string.IsNullOrWhiteSpace(product.barcode))
                return false;

            _inventory[product.barcode] = product;
            return await Task.FromResult(true);
        }

        public async Task<ProductDTO> UpdateProduct(ProductDTO product)
        {
            if (!_inventory.ContainsKey(product.barcode))
                throw new KeyNotFoundException("Product not found");

            _inventory[product.barcode] = product;
            return await Task.FromResult(product);
        }

        public async Task DeleteProduct(string barcode)
        {
            _inventory.Remove(barcode);
            await Task.CompletedTask;
        }

        public async Task<bool> CheckoutProduct(CheckoutDTO checkout)
        {
            if (!_inventory.ContainsKey(checkout.barcode))
                return await Task.FromResult(false);

            _inventory.Remove(checkout.barcode);
            return await Task.FromResult(true);
        }

        public async Task<IEnumerable<ProductDTO>> GetAllProducts()
        {
            return await Task.FromResult(_inventory.Values);
        }

        public async Task<ProductDTO?> GetProductByBarcode(string barcode)
        {
            return await Task.FromResult(_inventory.GetValueOrDefault(barcode));
        }
    }
}