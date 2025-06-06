namespace SariScan.API.Models.DTOS
{
    public class CheckoutDTO
    {
        public required string barcode { get; set; }
        public required int quantity { get; set; }
    }
}