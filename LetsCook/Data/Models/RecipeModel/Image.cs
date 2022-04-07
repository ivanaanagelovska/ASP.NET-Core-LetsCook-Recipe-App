namespace LetsCook.Data.Models.RecipeModel
{
    using System.ComponentModel.DataAnnotations;

    using Data.Common;

    public class Image : BaseModel<string>
    {
        public Image()
        {
            this.Id = new Guid().ToString();
        }

        [Required]
        public string ImageUrl { get; set; }

        public int RecipeId { get; set; }

        public virtual Recipe Recipe { get; set; }
    }
}
