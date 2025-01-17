﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Likha.Shared
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Image { get; set; }
        public List<Address> Addresses{ get; set; }

        [NotMapped]
        public string Password { get; set; }
      
    }
}
