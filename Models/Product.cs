using System.ComponentModel.DataAnnotations;

namespace LearnBlazor.Models;

public class Product
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Range(1, 1000)]
    public decimal Price { get; set; }
    public bool IsActive { get; set; }
    public IEnumerable<ProductProp> ProductProperties { get; set; }
    public Category Category { get; set; }
    public DateOnly AvailableAfter { get; set; } = DateOnly.FromDateTime(DateTime.Now);
}