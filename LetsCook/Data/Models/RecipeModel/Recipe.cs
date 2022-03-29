namespace LetsCook.Data.Models.RecipeModel
{
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class Recipe
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(RecipeNameMaxLenght)]
        public string Name { get; set; }

        [MaxLength(RecipeDescriptionMaxLenght)]
        public string Description { get; set; }

        // TODO: Check for max time
        public TimeSpan PreparationTime { get; set; }

        public TimeSpan? CookingTime { get; set; }

        public TimeSpan? RestTime { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int? CuisineId { get; set; }

        public Cuisine Cuisine { get; set; }

        public virtual ICollection<RecipeIngredient> Ingredients { get; set; } = new HashSet<RecipeIngredient>();

        // TODO: Add instructions group name
        [Required]
        public ICollection<Instruction> Instructions { get; set; } = new HashSet<Instruction>();

        public string Notes { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
