using Recipe_API.Dto.Category;

namespace Recipe_API.Services
{
    public interface ICategoryService
    {
        CategoryDTO GetById(int id);
        CategoryDTO Create(CategoryDTO categoryDTO);
        CategoryDTO Update(CategoryDTO categoryDTO);
        IEnumerable<CategoryDTO> GetAll();
    }
}
