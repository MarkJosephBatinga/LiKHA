using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Likha.Shared
{
    public class Address
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string Province { get; set; }
        public string Barangay { get; set; }
        public string Phone { get; set; }
        public string Other { get; set; }
        public int UserId { get; set; }
    }
}
