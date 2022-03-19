using Likha.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Likha.Client.Services
{
    interface IProductService
    {
        public List<Product> Products { get; set; }

        void LoadProducts();
    }
}
