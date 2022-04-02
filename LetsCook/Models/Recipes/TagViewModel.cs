namespace LetsCook.Models.Recipes
{
    using System.ComponentModel.DataAnnotations;
    using static LetsCook.Data.DataConstants;
    public class TagViewModel
    {
        [StringLength(TagNameMaxLenght, MinimumLength = 5)]
        public string TagName { get; set; }
    }
}