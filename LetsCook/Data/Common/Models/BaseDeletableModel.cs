namespace LetsCook.Data.Common
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public abstract class BaseDeletableModel<TKey> : BaseModel<TKey>, IDeletableEntity
    {
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
