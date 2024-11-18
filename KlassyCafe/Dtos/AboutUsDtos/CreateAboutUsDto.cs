using KlassyCafe.DAL.Entities;

namespace KlassyCafe.Dtos.AboutUsDtos
{
    public class CreateAboutUsDto
    {
        public string Title { get; }
        public string Description { get; }
        public int AboutUsImageId { get; set; }
        public AboutUsImage Images { get; set; }
    }
}
