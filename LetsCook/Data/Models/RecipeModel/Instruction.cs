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

        public int RecipeId { get; set; }

        public virtual Recipe Recipe { get; set; }
    }
}
