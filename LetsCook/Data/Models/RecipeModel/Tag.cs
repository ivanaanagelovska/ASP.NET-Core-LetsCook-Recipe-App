namespace LetsCook.Data.Models.RecipeModel
{
    using System.ComponentModel.DataAnnotations;
    
    using Data.Common;
    using static DataConstants;
    public class Tag : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(TagNameMaxLenght)]
        public string Name { get; set; }

        public virtual ICollection<RecipeTag> Recipes { get; set; } = new HashSet<RecipeTag>();
    }
}
