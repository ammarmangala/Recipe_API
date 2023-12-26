using System.ComponentModel.DataAnnotations.Schema;
using Recipe_API.Entities.Base;

namespace Recipe_API.Entities
{
    [Table("Recipes")]
    public class Recipe : BaseEntity
    {
        
        public string Title { get; set; }
        public DateTime Time { get; set; }
        public Difficulty Difficulty { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }

    }

    public enum Difficulty
    {
        Easy,
        Intermediate,
        Advanced
    }
}
