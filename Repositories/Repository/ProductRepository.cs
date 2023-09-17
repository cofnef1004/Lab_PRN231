 using BusinessObjects.Models;
using DataAccess.DAO;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
	public class ProductRepository : IProductRepository
	{
		public void SaveProduct(Product product) => ProductDAO.SaveProduct(product);

		public void DeleteProduct(Product product) => ProductDAO.DeleteProduct(product);

		public List<Product> GetAllProducts() => ProductDAO.GetAllProducts();

		public Product GetProductById(int productId) => ProductDAO.GetProductById(productId);

		public void UpdateProduct(Product product) => ProductDAO.UpdateProduct(product);
	}
}
