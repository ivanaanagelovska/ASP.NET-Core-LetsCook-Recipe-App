namespace LetsCook.Data.Common
{
    public interface IAuditInfo
    {
        DateTime CreatedOn { get; set; }

        DateTime? UpdatedOn { get; set; }
    }
}
