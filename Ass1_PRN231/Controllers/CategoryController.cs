
using BusinessObjects.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Interface;
using Repository.Repository;

namespace eStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryRepository repository = new CategoryRepository();


        [HttpGet]
        public ActionResult<IEnumerable<Category>> GetCategories() => repository.GetCategories();

        [HttpGet("{categoryId}")]
        public IActionResult GetCategory(int categoryId)
        {
            var category = repository.GetCategoryById(categoryId);

            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }
    }
}
