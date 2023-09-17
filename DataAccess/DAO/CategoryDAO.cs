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
		public static List<Category> GetCategories()
		{
			using (var context = new MyDbContext())
			{
				var list = new List<Category>();
				list = context.Categories.ToList();
			return list;
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
