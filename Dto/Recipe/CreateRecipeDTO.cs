namespace Recipe_API.Dto.Recipe
{
    public class CreateRecipeDTO
    {
        public string Title { get; set; }
        public DateTime Time { get; set; }
        public enum Difficulty { Easy, Intermediate, Advanced }
        public int CategoryId { get; set; }
    }
}
