namespace LetsCook.Data.Models.RecipeModel
{
    using System.ComponentModel.DataAnnotations;

    using Data.Common;
    using static DataConstants;
    public class Instruction : BaseModel<int>
    {
        public int StepNumber { get; set; }

        [Required]
        [MaxLength(InstructionTextMaxLength)]
        public string Text { get; set; }

        public int SubRecipeId { get; set; }

        public virtual SubRecipe SubRecipe { get; set; }
    }
}
