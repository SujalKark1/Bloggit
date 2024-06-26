﻿using Bloggit.Models;

namespace Bloggit.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategories();
        Task<Category> GetCategoryById(int id);
        Task<bool> AddCategory(CategoryDto categoryDto);
        Task<CategoryDto> UpdateCategory(UpdateCategoryDTO categoryDto);
        Task DeleteCategory(int id);
    }
}
