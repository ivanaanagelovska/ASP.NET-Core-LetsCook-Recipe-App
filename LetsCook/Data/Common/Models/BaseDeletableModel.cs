namespace LetsCook.Data.Common
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public abstract class BaseDeletableModel<TKey> : BaseModel<TKey>, IDeletableEntity
    {
        public bool isDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
