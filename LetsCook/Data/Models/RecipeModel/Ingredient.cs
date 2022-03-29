namespace LetsCook.Data.Models.RecipeModel
{
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class Ingredient
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(RecipeIngredientNameMaxLenght)]
        public string Name { get; set; }

        [MaxLength(RecipeIngredientUnitMaxLenght)]
        public string Unit { get; set; }

        public byte? Amount { get; set; }

        [MaxLength(RecipeIngredientNoteMaxLenght)]
        public string Note { get; set; }

        public virtual ICollection<RecipeIngredient> Recipes { get; set; } = new HashSet<RecipeIngredient>();

        // TODO: Add ingredient group name

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
