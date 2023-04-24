using System;

namespace Domain.Contracts
{
    public abstract class AuditableEntity<TId> : IAuditableEntity<TId>
    {
        public TId Id { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public string? LastModifiedBy { get; set; } = null;
        public DateTime? LastModifiedOn { get; set; } = null;
    }
}