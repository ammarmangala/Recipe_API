using System.ComponentModel.DataAnnotations.Schema;
using Recipe_API.Entities.Base;

namespace Recipe_API.Entities
{
    [Table("Ingredients")]
    public class Ingredient : BaseEntity
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public int RecipeId { get; set; }

        public Recipe Recipes { get; set; }
    }
}
