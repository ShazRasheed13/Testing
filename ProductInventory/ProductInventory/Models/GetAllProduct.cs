namespace ProductInventory.Models
{
    public class GetAllProductResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; } = string.Empty;
        public List<AddProductRequest>? Data { get; set; }
    }
}
