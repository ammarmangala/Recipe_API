using Recipe_API.Dto.Recipe;
using Recipe_API.Entities;

namespace Recipe_API.Profiles
{
    public class RecipeDTOProfile
    {
        public RecipeDTOProfile()
        {
            CreateMap<Recipe, RecipeDTO>();
            CreateMap<CreateRecipeDTO, Recipe>();
            CreateMap<UpdateRecipeDTO, Recipe>();
        }
    }
}
