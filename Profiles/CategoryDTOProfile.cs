using AutoMapper;
using Recipe_API.Dto.Category;
using Recipe_API.Entities;

namespace Recipe_API.Profiles
{
    public class CategoryDTOProfile : Profile
    {
        public CategoryDTOProfile()
        {
            CreateMap<Category, CategoryDTO>();
            CreateMap<CreateCategoryDTO, Category>();
            CreateMap<UpdateCategoryDTO, Category>();
        }
    }
}
