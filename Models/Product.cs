namespace LearnBlazor.Models;

public class Product
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public decimal Price { get; set; }
    public bool IsActive { get; set; }
    public required IEnumerable<ProductProp> ProductProperties { get; set; }
}