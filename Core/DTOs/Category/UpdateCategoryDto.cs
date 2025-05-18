namespace Core.DTOs.Category;

public class UpdateCategoryDto
{
    public required string Title { get; set; }
    public string? Image { get; set; }
}