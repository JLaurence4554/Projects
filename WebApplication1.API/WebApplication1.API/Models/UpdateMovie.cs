namespace WebApplication1.API.Models
{
    public class UpdateMovie
    {
        public int movieID { get; set; }
        public required string title { get; set; }
        public string movieprize { get; set; }
    }
}
