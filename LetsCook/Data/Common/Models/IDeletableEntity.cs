namespace LetsCook.Data.Common
{
    public interface IDeletableEntity
    {
        bool isDeleted { get; set; }

        DateTime? DeletedOn { get; set; }
    }
}
