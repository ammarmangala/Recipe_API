using Microsoft.EntityFrameworkCore;
using Recipe_API.Entities;
using Recipe_API.Data;

namespace Recipe_API.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly ApplicationDbContext _context;
        public IEnumerable<Recipe> GetAll()
        {
            return _context.Recipes.Include(x => x.Category).ToList();
        }
    }
}
