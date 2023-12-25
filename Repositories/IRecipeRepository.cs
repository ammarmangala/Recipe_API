using Recipe_API.Entities;

namespace Recipe_API.Repositories
{
    public interface IRecipeRepository
    {
        IEnumerable<Recipe> GetAll();
    }
}
