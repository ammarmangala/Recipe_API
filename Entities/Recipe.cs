using Template_Web_API.Entities.Base;

namespace Recipe_API.Entities
{
    public class Recipe : BaseEntity
    {
        public string Title { get; set; }
        public DateTime Time { get; set; }
        public enum Difficulty { Easy, Intermediate, Advanced }
        public int CategoryId { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }

        public Category Categories { get; set; }

    }

    public enum Difficulty
    {
        Easy,
        Intermediate,
        Advanced
    }
}
