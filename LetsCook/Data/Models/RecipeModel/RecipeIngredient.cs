namespace LetsCook.Data.Models.RecipeModel
{
    using System.ComponentModel.DataAnnotations;

    using Data.Common;

    using static DataConstants;

    public class RecipeIngredient : BaseModel<int>
    {
        public int RecipeId { get; set; }

        public virtual Recipe Recipe { get; set; }

        public int IngredientId { get; set; }

        public virtual Ingredient Ingredient { get; set; }

        [MaxLength(IngredientUnitMaxLenght)]
        public string Unit { get; set; }

        public decimal? Amount { get; set; }

        [MaxLength(IngredientNoteMaxLenght)]
        public string Note { get; set; }
    }
}
