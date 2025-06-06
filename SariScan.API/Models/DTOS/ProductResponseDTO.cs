namespace SariScan.API.Models.DTOS
{
    public class ProductResponseDTO
    {
        public required string name { get; set; }
        public required string category { get; set; }
        public required decimal price { get; set; }
        public required int stockAvailable { get; set; }
    }
}