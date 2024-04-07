using System.ComponentModel.DataAnnotations;

namespace NewApplication1.Models
{
    public class AddTravelViewModel
    {
        [Required(ErrorMessage = "Name Is Required")]
        [RegularExpression("^[A-Za-z]+(?: [A-Za-z]+)*$", ErrorMessage = "Name must contain only letters")]
        public required string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public required string Email { get; set; }
        [Phone]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Please enter a valid 10-digit phone number.")]
        public required string MobileNumber { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }
        public DateOnly DateofArrival { get; set; }
        public DateOnly DateofDepature { get; set; }
        [Required(ErrorMessage = "Destination Is Required")]
        public string Destination { get; set; }
        //[Required(ErrorMessage = " Required")]
        public required int Count { get; set; }
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$",
         ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one number, and be at least 8 characters long")]
        public required string Password { get; set; }
    }
}
