namespace KlassyCafe.DAL.Entities
{
    public class AboutUs
    {
        public int AboutUsId { get; set; }
        public string Title { get;}
        public string Description { get;}
        public int AboutUsImageId { get; set; }
        public AboutUsImage Images { get; set; }
        public int VideoId { get; set; }
        public Video Videos { get; set; }
    }
}
