using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace ProductInventory.Models
{
    public class AddProductRequest
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [Required]
        public double Price { get; set; }
        public string DateAdded { get; set; } = string.Empty; 
    }
    public class AddProductResponse
    {
        public string Message {get;set;} = string.Empty;
        public bool IsSuccess { get; set; }
    }
}
