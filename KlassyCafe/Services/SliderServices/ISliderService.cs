using KlassyCafe.Dtos.SliderDtos;

namespace KlassyCafe.Services.SliderServices
{
    public interface ISliderService
    {
        Task<List<ResultSliderDto>> GetAllSliderAsync();

        Task CreateSliderAsync(CreateSliderDto createSliderDto);
        Task UpdateSliderAsync(UpdateSliderDto updateSliderDto);
        Task DeleteSliderAsync(int id);
        Task<GetByIdSliderDto> GetByIdSliderAsync(int id);
        Task<List<ResultSliderDto>> GetAllSliderIsSliderTrue();
    }
}
