using Recipe_API.Dto.Category;

namespace Recipe_API.Services
{
    public interface ICategoryService
    {
        CategoryDTO GetById(int id);
        CategoryDTO Create(CreateCategoryDTO categoryDTO);
        IEnumerable<CategoryDTO> GetAll();
    }
}
