using Likha.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Likha.Server.Services.AddressService
{
    public interface IAddressService
    {
        Task<List<Address>> AddAddress(Address address);

        Task<List<Address>> LoadAddress(int UserId);

        Task<Address> GetAddress(int Id);

        Task<List<Address>> DeleteAddress(Address address);
    }
}
