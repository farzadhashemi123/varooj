using Core.DTOs.Product;
using Data.Repository.Contract;

namespace Data.Repository;

public class ProductRepository : IProductRepository
{
    public Task<List<ProductDto>> GetAllAsync { get; set; }
    public Task<List<ProductDto>> GetAllByCategoryIdAsync(int categoryId)
    {
        throw new NotImplementedException();
    }

    public Task<ProductDto> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ProductDto> CreateAsync(AddProductDto product)
    {
        throw new NotImplementedException();
    }

    public Task<ProductDto> UpdateAsync(UpdateProductDto product)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}