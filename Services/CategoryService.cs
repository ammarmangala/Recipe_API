using AutoMapper;
using Recipe_API.Dto.Category;
using Recipe_API.Entities;
using Template_Web_API.Repositories.Base;

namespace Recipe_API.Services
{
    public class CategoryService : ICategoryService
    {
        IRepository<Category> _categoryService;
        IMapper _mapper;
        public CategoryService(IRepository<Category> categoryRepository, IMapper mapper)
        {
            _categoryService = categoryRepository;
            _mapper = mapper;
        }

        public CategoryDTO Create(CategoryDTO categoryDTO)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public CategoryDTO GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
