using BusinessObjects.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories.Interface;
using Repositories.Repository;

namespace API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		private IProductRepository repository = new ProductRepository();

		[HttpGet]
		public ActionResult<IEnumerable<Product>> GetProducts() => repository.GetAllProducts();

		[HttpPost]
		public IActionResult PostProduct(Product p)
		{
			repository.SaveProduct(p);
			return NoContent();
		}

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
		{
			var p = repository.GetProductById(id);
			if(p == null)
				return NotFound();
			repository.DeleteProduct(p);
			return NoContent();
		}

		[HttpPut("{id}")]
		public IActionResult UpdateProduct(int id , Product product)
		{
			var p = repository.GetProductById(id);
			if (p == null)
				return NotFound();
			repository.UpdateProduct(product);
			return NoContent();
		}
	}
}
