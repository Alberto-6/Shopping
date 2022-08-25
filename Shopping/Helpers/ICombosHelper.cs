using Microsoft.AspNetCore.Mvc.Rendering;
using Shopping.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Helpers
{
    public interface ICombosHelper
    {
        Task<IEnumerable<SelectListItem>> GetComboCategoriesAsync();

        Task<IEnumerable<SelectListItem>> GetComboCategoriesAsync(IEnumerable<Category> filter);

        Task<IEnumerable<SelectListItem>> GetComboCountriesAsync();

       

    }
}
