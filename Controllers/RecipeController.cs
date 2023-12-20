using Microsoft.AspNetCore.Mvc;
using Recipe_API.Dto.Recipe;
using Recipe_API.Services;

namespace Recipe_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private IRecipeService _recipeService;

        public RecipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        [HttpGet("")]
        public ActionResult GetAll()
        {
            return Ok(_recipeService.GetAll());
        }


        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            RecipeDTO recipe = _recipeService.GetById(id);
            if (recipe == null)
            {
                return NotFound();
            }

            return Ok(recipe);
        }

        [HttpPost("")]
        public ActionResult Create(RecipeDTO recipeDTO)
        {
            RecipeDTO recipe = _recipeService.Create(recipeDTO);
            return CreatedAtAction(nameof(Get), new { id = recipe.Id }, recipe);
        }


        [HttpPut("{id}")]
        public ActionResult Update(int id, RecipeDTO recipeDTO)
        {
            if (id != recipeDTO.Id)
            {
                return BadRequest();
            }
            RecipeDTO recipe = _recipeService.Update(id, recipeDTO);
            if (recipe == null)
            {
                return NotFound();
            }
            return NoContent();
        }


        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            bool isDeleted = _recipeService.Delete(id);
            if (!isDeleted)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
