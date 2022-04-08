using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Likha.Shared
{
    public class AddProduct
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Insert A Title")]
        [MaxLength(30, ErrorMessage = "Max Length of 30 Letters Only")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is Required")]
        public string Description { get; set; }

        public string Artist { get; set; }
        public int ArtistId { get; set; }

        [Required(ErrorMessage = "Product needs an Image")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Please Insert a Price")]
        [Column(TypeName = "decimal(18,2)")]
        [Range(20, 9999999999.99, ErrorMessage = "Minimum price is 20")]
        public decimal Price { get; set; }
        
        [Required(ErrorMessage = "Please Select Category for your Product")]
        [Range(9, 100, ErrorMessage = "Invalid Category, Please Try Again")]
        public int CategoryId { get; set; }
    }
}
