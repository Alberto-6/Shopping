﻿using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Shopping.Data;
using Shopping.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext _context;

        public CombosHelper(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SelectListItem>> GetComboCategoriesAsync()
        {
            List<SelectListItem> list = await _context.Categories.Select(c => new SelectListItem
            {
                Text = c.Name,
                Value = c.Id.ToString()
            })
                .OrderBy(c => c.Text)
                .ToListAsync();

            list.Insert(0, new SelectListItem { Text = "[Seleccione una categoría...", Value = "0" });
            return list;
        }

        public async Task<IEnumerable<SelectListItem>> GetComboCategoriesAsync(IEnumerable<Category> filter)
        {

            List<Category> categories = await _context.Categories.ToListAsync();
            List<Category> categoriesFiltered = new List<Category>();
            foreach(Category category in categories)
            {
                if(!filter.Any(c => c.Id == category.Id)) 
                {
                    categoriesFiltered.Add(category);
                }
            }



            List<SelectListItem> list = categoriesFiltered.Select(c => new SelectListItem
            {
                Text = c.Name,
                Value = c.Id.ToString()
            })
             .OrderBy(c => c.Text)
             .ToList();

            list.Insert(0, new SelectListItem { Text = "[Seleccione una categoría...", Value = "0" });
            return list;
        }

        public async Task<IEnumerable<SelectListItem>> GetComboCountriesAsync()
        {
            List<SelectListItem> list = await _context.Countries.Select(c => new SelectListItem
            {
                Text = c.Name,
                Value = c.Id.ToString()
            })
             .OrderBy(c => c.Text)
             .ToListAsync();
            list.Insert(0, new SelectListItem { Text = "[Seleccione una pais...", Value = "0" });

            return list;
        }

        public Task<IEnumerable<SelectListItem>> GetComboStatesAsync(int countryId)
        {
            throw new NotImplementedException();
        }
    }
}
