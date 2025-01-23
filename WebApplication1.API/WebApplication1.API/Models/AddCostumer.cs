namespace WebApplication1.API.Models
{
    public class AddCostumer
    {
        public  AddCostumer() 
        {
            Costumers = new List<AddCostumer>();
        }
        public int costumerID {  get; set; }
        public required string Name { get; set; }
        public string Email { get; set; }
        public ICollection<AddCostumer> Costumers { get; set; }
    }
}
