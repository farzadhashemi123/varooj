namespace Data.Entities;

public class CategoryProducts
{
    public int CategoryId { get; set; }
    public int ProductId { get; set; }

    #region Relation

    public Category Category { get; set; }
    public Product Product { get; set; }

    #endregion
}