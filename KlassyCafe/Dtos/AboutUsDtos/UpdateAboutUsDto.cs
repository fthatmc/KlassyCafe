using KlassyCafe.DAL.Entities;

namespace KlassyCafe.Dtos.AboutUsDtos
{
    public class UpdateAboutUsDto
    {
        public int AboutUsId { get; set; }
        public string Title { get; }
        public string Description { get; }
        public int AboutUsImageId { get; set; }
        public AboutUsImage Images { get; set; }
    }
}
