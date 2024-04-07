using System.ComponentModel.DataAnnotations;

namespace NewApplication1.Models.Entities
{
    public class login
    {
        [Key]

        public required int Id { get; set; }
        [Required(ErrorMessage = "UserName Is Required")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
       
    }
}
