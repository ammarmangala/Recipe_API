using AutoMapper;
using Recipe_API.Dto.Recipe;
using Recipe_API.Entities;
using Template_Web_API.Repositories.Base;

namespace Recipe_API.Services
{
    public class RecipeService : IRecipeService
    {
        private IRepository<Recipe> _recipeRepository;
        private IMapper _mapper;

        public RecipeService(IRepository<Recipe> recipeRepository, IMapper mapper)
        {
            _recipeRepository = recipeRepository;
            _mapper = mapper;
        }
        public RecipeDTO Create(RecipeDTO dto)
        {
            Recipe recipe = _mapper.Map<Recipe>(dto);

            _mapper.Add(recipe);
            _recipeRepository.SaveChanges();

            RecipeDTO result = _mapper.Map<RecipeDTO>(recipe);
            return result;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RecipeDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public RecipeDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public RecipeDTO Update(int id, RecipeDTO recipeDTO)
        {
            throw new NotImplementedException();
        }
    }
}
