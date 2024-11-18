using KlassyCafe.Dtos.VideoDtos;

namespace KlassyCafe.Services.VideoServices
{
    public interface IVideoService
    {
        Task<List<ResultVideoDto>> GetAllVideoAsync();

        Task CreateVideoAsync(CreateVideoDto createVideoDto);
        Task UpdateVideoAsync(UpdateVideoDto updateVideoDto);
        Task DeleteVideoAsync(int id);
        Task<GetByIdVideoDto> GetByIdVideoAsync(int id);
    }
}
