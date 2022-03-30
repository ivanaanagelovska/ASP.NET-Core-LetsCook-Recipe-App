namespace LetsCook.Data.Models.RecipeModel
{
    using System.ComponentModel.DataAnnotations;

    using Data.Common;
    using static DataConstants;

    public class Ingredient : BaseDeletableModel<int>
    {

        [Required]
        [MaxLength(IngredientNameMaxLenght)]
        public string Name { get; set; }

        public virtual ICollection<RecipeIngredient> SubRecipes { get; set; } = new HashSet<RecipeIngredient>();
    }
}
