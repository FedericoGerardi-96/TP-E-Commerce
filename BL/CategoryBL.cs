﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BL
{
    public class CategoryBL
    {
        public List<Category> GetCategories()
        {
            var db = new DAL.BaseDataService<Category>();
            return db.Get();
        }
    }
}
