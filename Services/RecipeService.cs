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

        public RecipeDTO Create(CreateRecipeDTO dto)
        {
            Recipe recipe = _mapper.Map<Recipe>(dto);

            _recipeRepository.Add(recipe);
            _recipeRepository.SaveChanges();

            RecipeDTO result = _mapper.Map<RecipeDTO>(recipe);
            return result;
        }

        public bool Delete(int id)
        {
            Recipe toDelete = _recipeRepository.GetById(id);
            if (toDelete == null)
            {
                return false;
            }

            _recipeRepository.Delete(toDelete);
            _recipeRepository.SaveChanges();

            return true;
        }

        public IEnumerable<RecipeDTO> GetAll()
        {
            return _recipeRepository.GetAll().Select(_mapper.Map<RecipeDTO>);
        }

        public RecipeDTO GetById(int id)
        {
            Recipe recipe = _recipeRepository.GetById(id);
            if (recipe == null)
            {
                return null;
            }

            return _mapper.Map<RecipeDTO>(recipe);
        }

    }
}
