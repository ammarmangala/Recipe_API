using Recipe_API.Dto.Recipe;

namespace Recipe_API.Services
{
    public interface IRecipeService
    {
        RecipeDTO GetById(int id);
        RecipeDTO Create(RecipeDTO recipeDTO);
        RecipeDTO Update(int id, RecipeDTO recipeDTO);
        bool Delete(int id);
        IEnumerable<RecipeDTO> GetAll();
    }
}
