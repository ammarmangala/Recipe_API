using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Recipe_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("")]
        public ActionResult GetAll()
        {
            return Ok(_categoryService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            CategoryDTO category = _categoryService.GetById(id);
            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }

        [HttpPost("")]
        public ActionResult Create(CategoryDTO categoryDTO)
        {
            CategoryDTO category = _categoryService.Create(categoryDTO);
            return CreatedAtAction(nameof(Get), new { id = category.Id }, category);
        }
    }
}
