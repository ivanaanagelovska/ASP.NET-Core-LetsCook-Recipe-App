namespace LetsCook.Models.Recipes
{
    using System.ComponentModel.DataAnnotations;
    using static Data.DataConstants;
    public class CreateRecipeFormModel
    {
        [Required(ErrorMessage = "This is a required field")]
        [StringLength(RecipeNameMaxLenght, MinimumLength = RecipeNameMinLenght, ErrorMessage = "{0} should be between {2} and {1} characters")]
        [Display(Name = "Title")]

        public string Name { get; set; }
        
        [StringLength(RecipeDescriptionMaxLenght, MinimumLength = RecipeDescriptionMinLenght, ErrorMessage = "{0} should be between {2} and {1} characters")]
        [Display(Name = "Short Intro")]

        public string Description { get; set; }

        [Display(Name = "Prep time")]

        public TimeSpan PreparationTime { get; set; }

        [Display(Name = "Cook time")]
        public TimeSpan? CookingTime { get; set; }

        [Display(Name = "Rest time")]

        public TimeSpan? RestTime { get; set; }

        [Range(ServingsMinValue, ServingsMaxValue, ErrorMessage ="{0} should be between {1} and {2}.")]

        public int Servings { get; set; }

        public int CategoryId { get; set; }

        public IEnumerable<CategoryViewModel> Categories { get; set; }

        public int? CuisineId { get; set; }

        public IEnumerable<CuisineViewModel> Cuisines { get; set; }

        public int DifficultyId { get; set; }

        public IEnumerable<DifficultyViewModel> Difficulties { get; set; }

        //public virtual ICollection<RecipeIngredient> Ingredients { get; set; } = new HashSet<RecipeIngredient>();

        //public virtual ICollection<RecipeTag> Tags { get; set; } = new HashSet<RecipeTag>();

        //public virtual ICollection<Image> Images { get; set; } = new HashSet<Image>();

        //public virtual ICollection<Note> Notes { get; set; } = new HashSet<Note>();

        //public virtual ICollection<SubRecipe> SubRecipes { get; set; } = new HashSet<SubRecipe>();
    }
}
