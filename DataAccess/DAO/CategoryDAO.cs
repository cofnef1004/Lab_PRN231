using BusinessObjects.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
	public class CategoryDAO
	{
        public static List<Category> GetAllCategories()
        {
            using (var _context = new MyDbContext())
            {
                return _context.Categories.ToList();
            }
        }

        public static Category GetCategoryById(int cateId)
        {
            using (var _context = new MyDbContext())
            {
                return _context.Categories.SingleOrDefault(p => p.CategoryId == cateId);
            }
        }
    }
}
