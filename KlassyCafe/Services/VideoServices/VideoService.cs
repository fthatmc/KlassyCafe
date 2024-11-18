using AutoMapper;
using KlassyCafe.DAL.Context;
using KlassyCafe.DAL.Entities;
using KlassyCafe.Dtos.VideoDtos;
using Microsoft.EntityFrameworkCore;

namespace KlassyCafe.Services.VideoServices
{
    public class VideoService : IVideoService
    {
        private readonly KlassyContext _context;
        private readonly IMapper _mapper;

        public VideoService(KlassyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateVideoAsync(CreateVideoDto createVideoDto)
        {
            var values = _mapper.Map<Video>(createVideoDto);
            await _context.Videos.AddAsync(values);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteVideoAsync(int id)
        {
            var values = await _context.Videos.FindAsync(id);
            _context.Videos.Remove(values);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ResultVideoDto>> GetAllVideoAsync()
        {
            var values = await _context.Videos.ToListAsync();
            return _mapper.Map<List<ResultVideoDto>>(values);
        }

        public async Task<GetByIdVideoDto> GetByIdVideoAsync(int id)
        {
            var values = await _context.Videos.FindAsync(id);
            return _mapper.Map<GetByIdVideoDto>(values);
        }

        public async Task UpdateVideoAsync(UpdateVideoDto updateVideoDto)
        {
            var values = _mapper.Map<Video>(updateVideoDto);
            _context.Videos.Update(values);
            await _context.SaveChangesAsync();
        }
    }
}
