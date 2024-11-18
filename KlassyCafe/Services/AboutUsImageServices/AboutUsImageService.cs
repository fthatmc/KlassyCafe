using AutoMapper;
using KlassyCafe.DAL.Context;
using KlassyCafe.DAL.Entities;
using KlassyCafe.Dtos.AboutUsDtos;
using KlassyCafe.Dtos.AboutUsImageDtos;
using Microsoft.EntityFrameworkCore;

namespace KlassyCafe.Services.AboutUsImageServices
{
    public class AboutUsImageService : IAboutUsImageService
    {
        private readonly KlassyContext _context;
        private readonly IMapper _mapper;

        public AboutUsImageService(KlassyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateAboutUsImageAsync(CreateAboutUsImageDto createAboutUsImageDto)
        {
            var values = _mapper.Map<AboutUsImage>(createAboutUsImageDto);
            await _context.AboutUsImages.AddAsync(values);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAboutUsImageAsync(int id)
        {
            var values = await _context.AboutUsImages.FindAsync(id);
            _context.AboutUsImages.Remove(values);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ResultAboutUsImageDto>> GetAllAboutUsImageAsync()
        {
            var values = await _context.AboutUsImages.ToListAsync();
            return _mapper.Map<List<ResultAboutUsImageDto>>(values);
        }

        public async Task<GetByIdAboutUsImageDto> GetByIdAboutUsImageAsync(int id)
        {
            var values = await _context.AboutUsImages.FindAsync(id);
            return _mapper.Map<GetByIdAboutUsImageDto>(values);
        }

        public async Task UpdateAboutUsImageAsync(UpdateAboutUsImageDto updateAboutUsImageDto)
        {
            var values = _mapper.Map<AboutUsImage>(updateAboutUsImageDto);
            _context.AboutUsImages.Update(values);
            await _context.SaveChangesAsync();
        }
    }
}
