namespace Domain.Common.Interfaces;

public interface IAuditableEntity<T> : IEntity<T>
{
    DateTimeOffset Created { get; set; }

    string? CreatedBy { get; set; }

    DateTimeOffset LastModified { get; set; }

    string? LastModifiedBy { get; set; }
}