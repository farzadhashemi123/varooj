namespace Core.DTOs.Product;

public class UpdateProductDto
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Price { get; set; }
    public string? Image { get; set; }
    public string? Details { get; set; }
}