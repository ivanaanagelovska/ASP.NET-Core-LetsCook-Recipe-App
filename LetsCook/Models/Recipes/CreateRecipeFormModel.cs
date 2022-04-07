namespace LetsCook.Models.Recipes
{
    using System.ComponentModel.DataAnnotations;

    using Services.Recipes.Models;

    using static Data.DataConstants;

    public class CreateRecipeFormModel : IValidatableObject
    {
        [Required(ErrorMessage = "This is a required field")]
        [StringLength(RecipeNameMaxLenght, MinimumLength = RecipeNameMinLenght, ErrorMessage = "{0} should be between {2} and {1} characters")]
        [Display(Name = "Title")]
        public string Name { get; set; }

        [StringLength(RecipeDescriptionMaxLenght, MinimumLength = RecipeDescriptionMinLenght, ErrorMessage = "{0} should be between {2} and {1} characters")]
        [Display(Name = "Short Intro")]
        public string Description { get; set; }

        [Range(0, 23)]
        [Display(Name = "Prep time (hh)")]
        public int PreparationTimeHours { get; set; }

        [Range(0, 59)]
        [Display(Name = "Prep time (mm)")]
        public int PreparationTimeMinutes { get; set; }

        [Range(0, 23)]
        [Display(Name = "Cook time (hh)")]
        public int CookingTimeHours { get; set; }

        [Range(0, 59)]
        [Display(Name = "Cook time (mm)")]
        public int CookingTimeMinutes { get; set; }

        [Range(ServingsMinValue, ServingsMaxValue, ErrorMessage = "{0} should be between {1} and {2}.")]
        public int Servings { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public IEnumerable<CategoryServiceModel> Categories { get; set; }

        [Display(Name = "Cuisine")]
        public int? CuisineId { get; set; }

        public IEnumerable<CuisineServiceModel> Cuisines { get; set; }

        [Display(Name = "Difficulty")]
        public int DifficultyId { get; set; }

        public IEnumerable<DifficultyServiceModel> Difficulties { get; set; }

        public List<TagViewModel> Tags { get; set; } = new List<TagViewModel>();

        public List<ImageViewModel> Images { get; set; } = new List<ImageViewModel>();

        public List<NoteViewModel> Notes { get; set; } = new List<NoteViewModel>();

        public List<InstructionViewModel> Instructions { get; set; } = new List<InstructionViewModel>();

        public List<RecipeIngredientViewModel> Ingredients { get; set; } = new List<RecipeIngredientViewModel>();

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (PreparationTimeHours == 0 && PreparationTimeMinutes == 0)
            {
                yield return new ValidationResult("Enter at least minutes", new[] { "PreparationTimeMinutes" });
            }

            if (CookingTimeHours == 0 && CookingTimeMinutes == 0)
            {
                yield return new ValidationResult("Enter at least minutes", new[] { "CookingTimeMinutes" });
            }
        }
    }
}
