using AutoMapper;
using KlassyCafe.DAL.Context;
using KlassyCafe.DAL.Entities;
using KlassyCafe.Dtos.AboutUsDtos;
using KlassyCafe.Dtos.AboutUsImageDtos;
using Microsoft.EntityFrameworkCore;

namespace KlassyCafe.Services.AboutUsServices
{
    public class AboutUsServices : IAboutUsServices
    {

        private readonly KlassyContext _context;
        private readonly IMapper _mapper;

        public AboutUsServices(KlassyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateAboutUsAsync(CreateAboutUsDto createAboutUsDto)
        {
            var values = _mapper.Map<AboutUs>(createAboutUsDto);
            await _context.AboutUss.AddAsync(values);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAboutUsAsync(int id)
        {
            var values = await _context.AboutUss.FindAsync(id);
            _context.AboutUss.Remove(values);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ResultAboutUsDto>> GetAllAboutUsAsync()
        {
            var values = await _context.AboutUss.ToListAsync();
            return _mapper.Map<List<ResultAboutUsDto>>(values);
        }

        public async Task<List<ResultAboutUsDto>> GetAllAboutUsWithImageAndVideoAsync()
        {
            var values = await _context.AboutUss.Include(x => x.Images).Include(y=>y.Videos).ToListAsync();
            var list = values.Select(x => new ResultAboutUsDto
            {
                AboutUsId = x.AboutUsId,
                Title = x.Title,
                Description = x.Description,
                VideoId = x.VideoId,
                AboutUsImageId = x.AboutUsImageId,

            }).ToList();

            return _mapper.Map<List<ResultAboutUsDto>>(list);
        }

        public async Task<GetByIdAboutUsDto> GetByIdAboutUsAsync(int id)
        {
            var values = await _context.AboutUss.FindAsync(id);
            return _mapper.Map<GetByIdAboutUsDto>(values);
        }

        public async Task UpdateAboutUsAsync(UpdateAboutUsDto updateAboutUsDto)
        {
            var values = _mapper.Map<AboutUs>(updateAboutUsDto);
            _context.AboutUss.Update(values);
            await _context.SaveChangesAsync();
        }
    }
}
