namespace WebApplication1.API.Models
{
    public class UpdateCostumer
    {
        public int CostumerID { get; set; }
        public required string Name { get; set; }
        public string? Email {  get; set; }

    }
}
