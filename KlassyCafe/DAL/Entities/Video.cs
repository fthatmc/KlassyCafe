namespace KlassyCafe.DAL.Entities
{
    public class Video
    {
        public int VideoId { get; set; }
        public string VideoURL { get; set; }
        public List<AboutUs> AboutUss { get; set; }
    }
}
