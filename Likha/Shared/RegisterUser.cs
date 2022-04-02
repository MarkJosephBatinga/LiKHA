using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Likha.Shared
{
    public class RegisterUser
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [MinLength(8, ErrorMessage = "8 Minimum Characters Required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        [MaxLength(20, ErrorMessage = "20 Maximum Character Only")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "First Name is Required")]
        [MaxLength(30, ErrorMessage = "30 Maximum Character Only")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Phone Number is Required")]
        [Phone(ErrorMessage ="Invalid Phone Number")]
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Image { get; set; }
    }
}
