using Core.DTOs.Product;

namespace Data.Repository.Contract;

public interface IProductRepository
{
    public Task<List<ProductDto>> GetAllAsync { get; set; }
    public Task<List<ProductDto>> GetAllByCategoryIdAsync(int categoryId);
    public Task<ProductDto> GetByIdAsync(int id);
    public Task<ProductDto> CreateAsync(AddProductDto product);
    public Task<ProductDto> UpdateAsync(UpdateProductDto product);
    public Task<bool> DeleteAsync(int id);
    
}