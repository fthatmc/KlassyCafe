using AutoMapper;
using KlassyCafe.DAL.Context;
using KlassyCafe.DAL.Entities;
using KlassyCafe.Dtos.ProductDtos;
using Microsoft.EntityFrameworkCore;

namespace KlassyCafe.Services.ProductServices
{
    public class ProductServices : IProductServices
    {
        private readonly KlassyContext _context;
        private readonly IMapper _mapper;

        public ProductServices(KlassyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task ChangeToFalseIsFeature(int id)
        {
            var values = await _context.Products.FindAsync(id);
            values.IsFeature = false;
            _context.Products.Update(values);
            await _context.SaveChangesAsync();
        }

        public async Task ChangeToTrueIsFeature(int id)
        {
            var values = await _context.Products.FindAsync(id);
            values.IsFeature = true;
            _context.Products.Update(values);
            await _context.SaveChangesAsync();
        }

        public async Task CreateProductAsync(CreateProductDto createProductDto)
        {
            var values = _mapper.Map<Product>(createProductDto);
            await _context.Products.AddAsync(values);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(int id)
        {
            var values = await _context.Products.FindAsync(id);
            _context.Products.Remove(values);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            var values = await _context.Products.ToListAsync();
            return _mapper.Map<List<ResultProductDto>>(values);
        }

        public async Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync()
        {
            var values = await _context.Products.Include(x => x.Category).ToListAsync();
            var list = values.Select(x => new ResultProductWithCategoryDto
            {
                ProductId = x.ProductId,
                CategoryId = x.CategoryId,
                CategoryName = x.Category.CategoryName,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                IsFeature = x.IsFeature,
                Total = x.Total
            }).ToList();

            return _mapper.Map<List<ResultProductWithCategoryDto>>(list);
        }

        public async Task<GetByIdProductDto> GetByIdProductAsync(int id)
        {
            var values = await _context.Products.FindAsync(id);
            return _mapper.Map<GetByIdProductDto>(values);
        }

        public async Task<List<ResultProductDto>> GetProductIsFeatureTrue()
        {
            var values = await _context.Products.Where(x => x.IsFeature == true).ToListAsync();
            return _mapper.Map<List<ResultProductDto>>(values);
        }

        public async Task<List<ResultProductWithCategoryDto>> GetProductListByCategoryAsync(int id)
        {
            var values = await _context.Products.Where(x => x.CategoryId == id).ToListAsync();
            return _mapper.Map<List<ResultProductWithCategoryDto>>(values);
        }

        public async Task UpdateProductAsync(UpdateProductDto updateProductDto)
        {
            var values = _mapper.Map<Product>(updateProductDto);
            _context.Products.Update(values);
            await _context.SaveChangesAsync();
        }
    }
}
