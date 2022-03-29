namespace LetsCook.Data.Models.RecipeModel
{
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class Cuisine
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(RecipeCuisineNameMaxLenght)]
        public string Name { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; } = new HashSet<Recipe>();

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
