using KlassyCafe.Dtos.CategoryDtos;

namespace KlassyCafe.Services.CategoryServices
{
    public interface ICategoryServices
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();

        Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
        Task DeleteCategoryAsync(int id);
        Task<GetByIdCategoryDto> GetByIdCategoryAsync(int id);
    }
}
