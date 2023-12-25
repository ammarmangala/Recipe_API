using Recipe_API.Dto.Recipe;

namespace Recipe_API.Services
{
    public interface IRecipeService
    {
        RecipeDTO GetById(int id);
        RecipeDTO Create(CreateRecipeDTO recipeDTO);
        bool Delete(int id);
        IEnumerable<RecipeDTO> GetAll();
    }
}
