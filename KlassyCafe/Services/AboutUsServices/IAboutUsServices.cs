using KlassyCafe.Dtos.AboutUsDtos;
using KlassyCafe.Dtos.AboutUsImageDtos;

namespace KlassyCafe.Services.AboutUsServices
{
    public interface IAboutUsServices
    {
        Task<List<ResultAboutUsDto>> GetAllAboutUsAsync();
        Task<List<ResultAboutUsDto>> GetAllAboutUsWithImageAndVideoAsync();

        Task CreateAboutUsAsync(CreateAboutUsDto createAboutUsDto);
        Task UpdateAboutUsAsync(UpdateAboutUsDto updateAboutUsDto);
        Task DeleteAboutUsAsync(int id);
        Task<GetByIdAboutUsDto> GetByIdAboutUsAsync(int id);

    }
}
