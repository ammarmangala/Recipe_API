namespace Recipe_API.Dto.Recipe
{
    public class DeleteRecipeDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Time { get; set; }
        public enum Difficulty { Easy, Intermediate, Advanced }
        public int CategoryId { get; set; }
    }
}
