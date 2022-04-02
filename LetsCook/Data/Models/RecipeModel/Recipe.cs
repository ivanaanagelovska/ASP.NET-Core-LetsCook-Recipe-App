namespace LetsCook.Data.Models.RecipeModel
{
    using System.ComponentModel.DataAnnotations;

    using Data.Common;
    using static DataConstants;

    public class Recipe : BaseDeletableModel<int>
    {

        [Required]
        [MaxLength(RecipeNameMaxLenght)]
        public string Name { get; set; }

        [MaxLength(RecipeDescriptionMaxLenght)]
        public string Description { get; set; }

        public TimeSpan PreparationTime { get; set; }

        public TimeSpan? CookingTime { get; set; }

        public TimeSpan? RestTime { get; set; }

        public int Servings { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public int? CuisineId { get; set; }

        public virtual Cuisine Cuisine { get; set; }

        public int DifficultyId { get; set; }

        public virtual Difficulty Difficulty { get; set; }

        public virtual ICollection<RecipeTag> Tags { get; set; } = new HashSet<RecipeTag>();

        public virtual ICollection<Image> Images { get; set; } = new HashSet<Image>();

        public virtual ICollection<Note> Notes { get; set; } = new HashSet<Note>();

        public virtual ICollection<RecipeIngredient> Ingredients { get; set; } = new HashSet<RecipeIngredient>();
        public virtual ICollection<Instruction> Instructions { get; set; } = new HashSet<Instruction>();
    }
}
