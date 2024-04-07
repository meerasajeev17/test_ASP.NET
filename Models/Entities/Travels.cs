using System.ComponentModel.DataAnnotations;

namespace NewApplication1.Models.Entities
{
    public class Travels
    {
        [Key]
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Email { get; set; }

        public required string MobileNumber { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }
        public DateOnly DateofArrival { get; set; }
        public DateOnly DateofDepature { get; set; }
        public required string Destination { get; set; }
        public required int Count { get; set; }
        public required string Password { get; set; }

    }
}
