namespace LetsCook.Data.Models.RecipeModel
{
    using System.ComponentModel.DataAnnotations;

    using Data.Common;
    using static DataConstants;

    public class Category : BaseDeletableModel<int>
    {

        [Required]
        [MaxLength(CategoryNameMaxLenght)]
        public string Name { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; } = new HashSet<Recipe>();
    }
}
