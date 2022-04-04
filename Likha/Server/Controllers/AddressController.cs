using Likha.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Likha.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        List<Address> Addresses = new List<Address>
        {
            new Address
            {
                LastName = "Lagrana",
                FirstName = "Maya Kayne",
                Street = "Lipit St",
                Town = "San Narciso",
                Province = "Zambales",
                Barangay = "Alusiis",
                Phone = "09501109163",
                Other = "",
                UserId = 2
            },
             new Address
            {
                LastName = "Copias",
                FirstName = "Shara",
                Street = "Lipit St",
                Town = "San Narciso",
                Province = "Zambales",
                Barangay = "Alusiis",
                Phone = "09501109163",
                Other = "",
                UserId = 2
            }
        };

        [HttpPost]
        public async Task<ActionResult<List<Address>>> AddAddress(Address address)
        {
            Addresses.Add(address);
            return Ok(Addresses);
        }

        [HttpGet("{UserId:int}")]
        public async Task<ActionResult<List<Address>>> LoadAddresses(int UserId)
        {
            var UserAddresses = Addresses.FindAll(a => a.UserId == UserId);
            return Ok(UserAddresses);
        }
    }
}
