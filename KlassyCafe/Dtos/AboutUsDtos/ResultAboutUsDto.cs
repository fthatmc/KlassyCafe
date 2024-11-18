using KlassyCafe.DAL.Entities;

namespace KlassyCafe.Dtos.AboutUsDtos
{
    public class ResultAboutUsDto
    {
        public int AboutUsId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int AboutUsImageId { get; set; }
        public AboutUsImage Images { get; set; }
        public int VideoId { get; set; }
        public Video Videos { get; set; }
    }
}
