using System.ComponentModel.DataAnnotations.Schema;
using Recipe_API.Entities.Base;

namespace Recipe_API.Entities
{

    [Table("Categories")]
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Recipe> Recipes { get; set; }
    }
}
