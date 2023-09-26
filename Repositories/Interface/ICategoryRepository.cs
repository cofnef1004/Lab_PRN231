﻿
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
	public interface ICategoryRepository
	{
        List<Category> GetCategories();
        Category GetCategoryById(int id);
    }
}
