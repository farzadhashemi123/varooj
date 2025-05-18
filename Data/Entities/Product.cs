using System.ComponentModel.DataAnnotations;
using Data.Entities.Base;

namespace Data.Entities;

public class Product : BaseEntity
{
    public required string Title { get; set; }
    public required string Price { get; set; }
    public string? Image { get; set; }
    public string? Details { get; set; }

    #region relation

    public List<CategoryProducts> CategoryProductsList { get; set; }

    #endregion
}
