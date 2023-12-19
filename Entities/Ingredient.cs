﻿using Template_Web_API.Entities.Base;

namespace Recipe_API.Entities
{
    public class Ingredient : BaseEntity
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public int RecipeId { get; set; }
    }
}
