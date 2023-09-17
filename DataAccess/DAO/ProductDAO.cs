using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class ProductDAO
    {
        /*		private readonly MyDbContext _context = new MyDbContext();

                public ProductDAO(MyDbContext context)
                {
                    _context = context;
                }*/

        public static List<Product> GetAllProducts()
        {
            using (var _context = new MyDbContext())
            {
                return _context.Products.ToList();
            }
        }

        public static Product GetProductById(int productId)
        {
            using (var _context = new MyDbContext())
            {
                return _context.Products.SingleOrDefault(p => p.ProductId == productId);
            }
        }

        public static void SaveProduct(Product product)
        {
            using (var _context = new MyDbContext())
            {
                var category = _context.Categories.Find(product.CategoryId);
                var _product = new Product()
                {
                    CategoryId = product.CategoryId,
                    ProductName = product.ProductName,
                    UnitPrice = product.UnitPrice,
                    UnitsInStock = product.UnitsInStock,
                    Category = category

                };
                _context.Products.Add(_product);
                _context.SaveChanges();
            }
        }


        public static void UpdateProduct(Product product)
        {
            using (var _context = new MyDbContext())
            {
                var category = _context.Categories.Find(product.CategoryId);
                var product1 = _context.Products.SingleOrDefault(p => p.ProductId == product.ProductId);
                if (product1 != null)
                {
                    var _product1 = new Product()
                    {
                        CategoryId = product.CategoryId,
                        ProductName = product.ProductName,
                        UnitPrice = product.UnitPrice,
                        UnitsInStock = product.UnitsInStock,
                        Category = category
                    };
                    _context.Products.Update(product1);
                    _context.SaveChanges();
                }
            }
        }

        public static void DeleteProduct(Product product)
        {
            using (var _context = new MyDbContext())
            {
                var product1 = _context.Products.SingleOrDefault(p => p.ProductId == product.ProductId);
                if (product1 != null)
                {
                    _context.Products.Remove(product1);
                    _context.SaveChanges();
                }
            }
        }
    }
}
