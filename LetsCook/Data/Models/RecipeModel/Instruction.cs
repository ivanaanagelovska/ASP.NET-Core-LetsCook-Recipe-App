using System.ComponentModel.DataAnnotations;

namespace LetsCook.Data.Models.RecipeModel
{
    public class Instruction
    {
        public int Id { get; init; }

        [Required]
        public string Description { get; set; }

        public int RecipeId { get; set; }

        public Recipe Recipe { get; set; }

        // TODO: Add instruction group name

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
