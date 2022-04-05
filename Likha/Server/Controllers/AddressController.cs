using Likha.Server.Services.AddressService;
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
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpPost]
        public async Task<ActionResult<List<Address>>> AddAddress(Address address)
        {
            var addresses = await _addressService.AddAddress(address);
            if (addresses == null)
                return NotFound(addresses);
            return Ok(addresses);
        }

        [HttpGet("{UserId:int}")]
        public async Task<ActionResult<List<Address>>> LoadAddresses(int UserId)
        {
            var UserAddresses = await _addressService.LoadAddress(UserId);
            return Ok(UserAddresses);
        }

        [HttpGet("address/{Id:int}")]
        public async Task<ActionResult<Address>> GetAddress(int Id)
        {
            var Address = await _addressService.GetAddress(Id);
            if (Address == null)
                return NotFound(Address);
            return Ok(Address);
        }

        [HttpPost("delete")]
        public async Task<ActionResult<List<Address>>> DeleteAddress(Address address)
        {
            var Addresses = await _addressService.DeleteAddress(address);
            if (Addresses == null)
                return NotFound(Addresses);
            return Ok(Addresses);
        }
    }
}
