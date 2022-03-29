namespace LetsCook.Data.Models.RecipeModel
{
    using System.ComponentModel.DataAnnotations;
    
    using Data.Common;
    using static DataConstants;

    public class Note : BaseModel<int>
    {
        [Required]
        [MaxLength(RecipeNoteMaxLenght)]
        public string Text { get; set; }

        public int RecipeId { get; set; }

        public virtual Recipe Recipe { get; set; }
    }
}
