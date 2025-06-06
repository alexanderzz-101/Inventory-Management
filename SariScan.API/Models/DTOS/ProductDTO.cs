namespace SariScan.API.Models.DTOS
{
    public class ProductDTO
    {
        public required string Barcode { get; set; }
        public required string Name { get; set; }
        public required decimal Price { get; set; }
        public required string Category { get; set; }
    }
}