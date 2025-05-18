namespace Core.DTOs.Category;

public class CategoryDto
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public string? Image { get; set; }
}