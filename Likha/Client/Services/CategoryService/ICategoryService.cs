using Likha.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Likha.Client.Services
{
    interface ICategoryService
    {
        List<Category> Categories { get; set; }

        Task LoadCategories();
    }
}
