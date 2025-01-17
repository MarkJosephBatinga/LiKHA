﻿using Likha.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Likha.Client.Services.AddressService
{
    interface IAddressService
    {
        public event Action OnChange;
        public List<Address> Addresses { get; set; }
        Task<List<Address>> AddAddress(Address address);
        Task LoadAddresses(int UserId);
        Task<Address> GetAddress(int Id);
        Task<List<Address>> DeleteAddress(Address address);
        Task<List<Address>> UpdateAddress(Address address);
    }
}
