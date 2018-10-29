using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneDentalCare.Models
{
    public class Login
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter User Name!")]
        [Display(Name ="User Name")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Please enter Password!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
