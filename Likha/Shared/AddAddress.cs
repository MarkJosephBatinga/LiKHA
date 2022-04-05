using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Likha.Shared
{
    public class AddAddress
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is Required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "First Name is Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Street or House Number is Required")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Town is Required")]
        public string Town { get; set; }

        [Required(ErrorMessage = "Province is Required")]
        public string Province { get; set; }

        [Required(ErrorMessage = "Barangay is Required")]
        public string Barangay { get; set; }

        [Required(ErrorMessage = "Mobile or Phone is Required")]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        public string Phone { get; set; }
        public string Other { get; set; }
    }
}
