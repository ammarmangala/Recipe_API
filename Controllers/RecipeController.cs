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
        public ActionResult Create(CreateRecipeDTO dto)
        {
            RecipeDTO createdRecipe = _recipeService.Create(dto);
            return CreatedAtAction(nameof(Get), new { id = createdRecipe.Id }, createdRecipe);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id, DeleteRecipeDTO dto)
        {
            bool isDeleted = _recipeService.Delete(id);
            if (isDeleted)
            {
                return NoContent();
            }
            else
            {
                return NotFound();

            }
        }
    }
}
