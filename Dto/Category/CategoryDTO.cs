﻿using Recipe_API.Entities;

namespace Recipe_API.Dto.Category
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Recipe_API.Entities.Recipe> Recipes { get; set; }
    }
}
