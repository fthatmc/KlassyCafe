using KlassyCafe.Dtos.AboutUsDtos;
using KlassyCafe.Dtos.AboutUsImageDtos;

namespace KlassyCafe.Services.AboutUsImageServices
{
    public interface IAboutUsImageService
    {
        Task<List<ResultAboutUsImageDto>> GetAllAboutUsImageAsync();

        Task CreateAboutUsImageAsync(CreateAboutUsImageDto createAboutUsImageDto);
        Task UpdateAboutUsImageAsync(UpdateAboutUsImageDto updateAboutUsImageDto);
        Task DeleteAboutUsImageAsync(int id);
        Task<GetByIdAboutUsImageDto> GetByIdAboutUsImageAsync(int id);
    }
}
