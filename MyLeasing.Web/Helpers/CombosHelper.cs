﻿using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyLeasing.Web.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyLeasing.Web.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext _dataContext;

        public CombosHelper(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IEnumerable<SelectListItem> GetComboPropetyTypes()
        {
            List<SelectListItem> list = _dataContext.PropertyTypes.Select(pt => new SelectListItem
            {
                Text = pt.Name,
                Value = $"{pt.Id}"
            })
                .OrderBy(pt => pt.Text)
                .ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "{Select a property type..}",
                Value = "0"
            });
            return list;
        }

        public IEnumerable<SelectListItem> GetComboLessees()
        {
            var list = _dataContext.Lessees.Include(l => l.User).Select(l => new SelectListItem
            {
                Text = l.User.FullNameWithDocument,
                Value = l.Id.ToString()
            }).OrderBy(l => l.Text).ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "(Select a lessee...)",
                Value = "0"
            });
            return list;
        }
    }
}