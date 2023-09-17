using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
	public interface IProductRepository
	{
		List<Product> GetAllProducts();
		Product GetProductById(int productId);
		void SaveProduct(Product product);
		void UpdateProduct(Product product);
		void DeleteProduct(Product product);
	}
}
