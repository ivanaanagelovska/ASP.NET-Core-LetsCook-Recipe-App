namespace LetsCook.Data.Models.RecipeModel
{
    using Data.Common;
    using System.ComponentModel.DataAnnotations;
    using static DataConstants;
    public class SubRecipe : BaseModel<int>
    {
        [MaxLength(RecipePartNameMaxLenght)]
        public string Name { get; set; }

        public virtual ICollection<Instruction> Instructions { get; set; } = new HashSet<Instruction>();

        public virtual ICollection<RecipeIngredient> Ingredients { get; set; } = new HashSet<RecipeIngredient>();

        public int RecipeId { get; set; }

        public virtual Recipe Recipe { get; set; }
    }
}
