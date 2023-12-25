using Template_Web_API.Entities.Base;

namespace Recipe_API.Dto.Recipe
{
    public class RecipeDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Time { get; set; }
        public Difficulty Difficulty { get; set; }
        public int CategoryId { get; set; }

    }

    public enum Difficulty
    {
        Easy,
        Intermediate,
        Advanced
    }
}
