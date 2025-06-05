namespace SariScan.API.Models.DTOS
{
    public class ProductResponseDTO
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int StockAvailable { get; set; }
    }
}