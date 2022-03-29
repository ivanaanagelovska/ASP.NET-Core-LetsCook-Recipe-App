namespace LetsCook.Models.Recipes
{
    public class AddRecipeFormModel
    {
        public string Name { get; init; }

        public string Description { get; init; }

        public TimeSpan PreparationTime { get; init; }

        public TimeSpan? CookingTime { get; init; }

        public TimeSpan? RestTime { get; init; }

        public int CategoryId { get; init; }

        //public Category Category { get; set; }

        //public int? CuisineId { get; set; }

        //public Cuisine Cuisine { get; set; }

        //public Difficulty Difficulty { get; set; }

        //public DietTag DietTag { get; set; }

        //public virtual ICollection<RecipeIngredient> Ingredients { get; set; } = new HashSet<RecipeIngredient>();

        //// TODO: Add instructions group name
        //[Required]
        //public ICollection<Instruction> Instructions { get; set; } = new HashSet<Instruction>();
    }
}
