using AutoMapper;
using KlassyCafe.DAL.Entities;
using KlassyCafe.Dtos.AboutUsDtos;
using KlassyCafe.Dtos.AboutUsImageDtos;
using KlassyCafe.Dtos.CategoryDtos;
using KlassyCafe.Dtos.ProductDtos;
using KlassyCafe.Dtos.SliderDtos;
using KlassyCafe.Dtos.VideoDtos;

namespace KlassyCafe.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<AboutUs, ResultAboutUsDto>().ReverseMap();
            CreateMap<AboutUs, CreateAboutUsDto>().ReverseMap();
            CreateMap<AboutUs, UpdateAboutUsDto>().ReverseMap();
            CreateMap<AboutUs, GetByIdAboutUsDto>().ReverseMap();

            CreateMap<AboutUsImage, ResultAboutUsImageDto>().ReverseMap();
            CreateMap<AboutUsImage, CreateAboutUsImageDto>().ReverseMap();
            CreateMap<AboutUsImage, UpdateAboutUsImageDto>().ReverseMap();
            CreateMap<AboutUsImage, GetByIdAboutUsImageDto>().ReverseMap();

            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, GetByIdCategoryDto>().ReverseMap();

            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, GetByIdProductDto>().ReverseMap();
            CreateMap<Product, ResultProductDto>().ReverseMap();

            CreateMap<Slider, CreateSliderDto>().ReverseMap();
            CreateMap<Slider, UpdateSliderDto>().ReverseMap();
            CreateMap<Slider, GetByIdSliderDto>().ReverseMap();
            CreateMap<Slider, ResultSliderDto>().ReverseMap();

            CreateMap<Video, CreateVideoDto>().ReverseMap();
            CreateMap<Video, UpdateVideoDto>().ReverseMap();
            CreateMap<Video, GetByIdVideoDto>().ReverseMap();
            CreateMap<Video, ResultVideoDto>().ReverseMap();
        }
    }
}
