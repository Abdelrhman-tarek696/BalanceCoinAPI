﻿using BalanceCoinAPI.DTOs;

namespace BalanceCoinAPI.Application.Services
{
    public interface ICategoryService
    {
        Task<List<CategoryDTO>> GetCategoriesAsync();
        Task<CategoryDTO> GetCategoryByIdAsync(int id);
        Task<CategoryDTO> CreateGategoryAsync(CategoryDTO categoryDTO);
        Task<bool> DeleteCategoryAsync(int id);
        Task<CategoryDTO>UpdateCategoryAsync(int id,CategoryDTO categoryDTO);

    }
}
