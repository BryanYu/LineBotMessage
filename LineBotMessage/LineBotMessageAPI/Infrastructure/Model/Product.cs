using System.ComponentModel.DataAnnotations;

namespace LineBotMessageAPI.Infrastructure.Model;

public class Product
{
    public int Id { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    
    public decimal Price { get; set; }
}