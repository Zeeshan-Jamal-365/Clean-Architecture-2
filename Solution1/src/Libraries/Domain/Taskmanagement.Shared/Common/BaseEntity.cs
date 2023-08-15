using Taskmanagement.Shared.Enum;

namespace Taskmanagement.Shared.Common;

public class BaseEntity
{
    public DateTimeOffset Created { get; set; }
    public string CreatedBy = string.Empty;
    public DateTimeOffset? LastModified { get; set; }
    public string? LastModifiedBy { get; set; }
    public EntityStatus Status { get; set; }
}
