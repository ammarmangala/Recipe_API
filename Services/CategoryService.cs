using AutoMapper;
using Recipe_API.Dto.Category;
using Recipe_API.Entities;
using Recipe_API.Repositories.Base;

namespace Recipe_API.Services
{
    public class CategoryService : ICategoryService
    {
        private IRepository<Category> _categoryService;
        private IMapper _mapper;
        public CategoryService(IRepository<Category> categoryRepository, IMapper mapper)
        {
            _categoryService = categoryRepository;
            _mapper = mapper;
        }

        public CategoryDTO Create(CreateCategoryDTO dto)
        {
            Category category = _mapper.Map<Category>(dto);

            _categoryService.Add(category);
            _categoryService.SaveChanges();

            CategoryDTO result = _mapper.Map<CategoryDTO>(category);
            return result;
        }


        public IEnumerable<CategoryDTO> GetAll()
        {
            return _categoryService.GetAll().Select(_mapper.Map<CategoryDTO>);
        }

        public CategoryDTO GetById(int id)
        {
            Category category = _categoryService.GetById(id);
            if (category == null)
            {
                return null;
            }

            return _mapper.Map<CategoryDTO>(category);
        }
    }
}
