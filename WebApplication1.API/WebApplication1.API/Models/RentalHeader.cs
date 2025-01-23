using Microsoft.AspNetCore.Routing.Template;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.API.Models
{
    public class RentalHeader
    {
        [Key]
        public int RentalID { get; set; }
        [ForeignKey("costumer")]
        public int costumerID { get; set; }
        [ForeignKey("movie")]
        public int movieID { get; set; }
        public DateTime RentalStart { get; set; }
        public DateTime RentalEnd { get; set; }
        public int RentalDuration { get; set; }
    }
}
