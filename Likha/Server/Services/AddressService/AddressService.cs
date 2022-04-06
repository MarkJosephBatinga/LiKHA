using Likha.Server.Data;
using Likha.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Likha.Server.Services.AddressService
{
    public class AddressService : IAddressService
    {
        private readonly DataContext _data;

        public AddressService(DataContext data)
        {
            _data = data;
        }
        public async Task<List<Address>> AddAddress(Address address)
        {
            await _data.Addresses.AddAsync(address);
            await _data.SaveChangesAsync();
            var addresses = await _data.Addresses.ToListAsync();
            return addresses;
        }

        public async Task<List<Address>> DeleteAddress(Address address)
        {
            _data.Addresses.Remove(address);
            await _data.SaveChangesAsync();
            var addresses = await _data.Addresses.ToListAsync();
            return addresses;
        }

        public async Task<Address> GetAddress(int Id)
        {
            var address = await _data.Addresses.FindAsync(Id);
            return address;
        }

        public async Task<List<Address>> LoadAddress(int UserId)
        {
            var userAddresses = await _data.Addresses.Where(a => a.UserId == UserId).ToListAsync();
            return userAddresses;
        }

        public async Task<List<Address>> UpdateAddress(Address address)
        {
            List<Address> Addresses = await _data.Addresses.ToListAsync();
            var dbAddress = await _data.Addresses.FindAsync(address.Id);
            if (dbAddress != null)
            {
                _data.Entry(dbAddress).CurrentValues.SetValues(address);
                await _data.SaveChangesAsync();
            }
            return Addresses;
        }
    }
}
