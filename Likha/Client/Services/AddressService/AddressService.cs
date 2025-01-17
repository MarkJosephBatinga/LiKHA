﻿using Likha.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Likha.Client.Services.AddressService
{
    public class AddressService : IAddressService
    {
        private readonly HttpClient _http;

        public AddressService(HttpClient http)
        {
            _http = http;
        }

        public List<Address> Addresses { get; set; } = new List<Address>();

        public event Action OnChange;

        public async Task<List<Address>> AddAddress(Address address)
        {
            var result = await _http.PostAsJsonAsync<Address>($"api/address", address);
            var addresses = await result.Content.ReadFromJsonAsync<List<Address>>();
            return addresses;
        }

        public async Task<List<Address>> DeleteAddress(Address address)
        {
            var result = await _http.PostAsJsonAsync<Address>($"api/address/delete", address);
            var addresses = await result.Content.ReadFromJsonAsync<List<Address>>();
            return addresses;
        }

        public async Task<Address> GetAddress(int Id)
        {
            var address = await _http.GetFromJsonAsync<Address>($"api/address/address/{Id}");
            return address;
        }

        public async Task LoadAddresses(int UserId)
        {
            Addresses = await _http.GetFromJsonAsync<List<Address>>($"api/address/{UserId}");
            OnChange.Invoke();
        }

        public async Task<List<Address>> UpdateAddress(Address address)
        {
            var result = await _http.PutAsJsonAsync<Address>($"api/address/update/{address.Id}", address);
            var addresses = await result.Content.ReadFromJsonAsync<List<Address>>();
            return addresses;
        }
    }
}
