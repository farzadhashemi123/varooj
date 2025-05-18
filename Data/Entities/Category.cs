using System.Security.AccessControl;
using Data.Entities.Base;

namespace Data.Entities;

public class Category : BaseEntity
{
    public required string Title { get; set; }
    public string? Image { get; set; }

    #region relation

    public List<CategoryProducts> CategoryProductsList { get; set; }
    #endregion


}