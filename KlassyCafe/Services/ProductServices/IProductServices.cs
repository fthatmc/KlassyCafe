using KlassyCafe.Dtos.ProductDtos;

namespace KlassyCafe.Services.ProductServices
{
    public interface IProductServices
    {
        Task<List<ResultProductDto>> GetAllProductAsync();

        Task CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task DeleteProductAsync(int id);
        Task<GetByIdProductDto> GetByIdProductAsync(int id);
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync();
        Task ChangeToTrueIsFeature(int id);
        Task ChangeToFalseIsFeature(int id);
        Task<List<ResultProductDto>> GetProductIsFeatureTrue();
        Task<List<ResultProductWithCategoryDto>> GetProductListByCategoryAsync(int id);
    }
}
