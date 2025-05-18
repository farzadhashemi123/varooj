using Core.DTOs.Category;
using Data.Context;
using Data.Entities;
using Data.Repository.Contract;

namespace Data.Repository;

public class CategoryRepository (VarojContext _context) : ICategoryRepository
{
    public Task<List<CategoryDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<CategoryDto> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<CategoryDto> AddAsync(AddCategoryDto category)
    {
        throw new NotImplementedException();
    }

    public Task<CategoryDto> UpdateAsync(UpdateCategoryDto category)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}