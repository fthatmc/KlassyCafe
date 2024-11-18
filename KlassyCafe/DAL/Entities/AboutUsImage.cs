namespace KlassyCafe.DAL.Entities
{
    public class AboutUsImage
    {
        public int AboutUsImageId { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }

        public List<AboutUs> AboutUss { get; set; }
    }
}
