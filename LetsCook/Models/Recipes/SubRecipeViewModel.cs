namespace LetsCook.Models.Recipes
{
    public class SubRecipeViewModel
    {
        public string Name { get; set; }

        public  ICollection<InstructionViewModel> Instructions { get; set; }

        public  ICollection<RecipeIngredientViewModel> Ingredients { get; set; }
    }
}