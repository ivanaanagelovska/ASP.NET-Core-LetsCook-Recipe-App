namespace LetsCook.Data.Models.RecipeModel
{
    using System.ComponentModel.DataAnnotations;
    
    using Data.Common;
    using static DataConstants;

    public class Difficulty : BaseModel<int>
    {
        [Required]
        [MaxLength(DifficultyNameMaxLenght)]
        public string Name { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; } = new HashSet<Recipe>();
    }
}
