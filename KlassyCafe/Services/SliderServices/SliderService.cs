using AutoMapper;
using KlassyCafe.DAL.Context;
using KlassyCafe.DAL.Entities;
using KlassyCafe.Dtos.SliderDtos;
using Microsoft.EntityFrameworkCore;

namespace KlassyCafe.Services.SliderServices
{
    public class SliderService : ISliderService
    {
        private readonly KlassyContext _context;
        private readonly IMapper _mapper;

        public SliderService(KlassyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateSliderAsync(CreateSliderDto createSliderDto)
        {
            var values = _mapper.Map<Slider>(createSliderDto);
            await _context.Sliders.AddAsync(values);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteSliderAsync(int id)
        {
            var values = await _context.Sliders.FindAsync(id);
            _context.Sliders.Remove(values);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ResultSliderDto>> GetAllSliderAsync()
        {
            var values = await _context.Sliders.ToListAsync();
            return _mapper.Map<List<ResultSliderDto>>(values);
        }

        public async Task<List<ResultSliderDto>> GetAllSliderIsSliderTrue()
        {
            var values = await _context.Sliders.Where(x => x.IsSlider == true).ToListAsync();
            return _mapper.Map<List<ResultSliderDto>>(values);
        }

        public async Task<GetByIdSliderDto> GetByIdSliderAsync(int id)
        {
            var values = await _context.Sliders.FindAsync(id);
            return _mapper.Map<GetByIdSliderDto>(values);
        }

        public async Task UpdateSliderAsync(UpdateSliderDto updateSliderDto)
        {
            var values = _mapper.Map<Slider>(updateSliderDto);
            _context.Sliders.Update(values);
            await _context.SaveChangesAsync();
        }
    }
}
