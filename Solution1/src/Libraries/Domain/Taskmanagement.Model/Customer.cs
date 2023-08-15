using Taskmanagement.Shared.Common;

namespace Taskmanagement.Model;

public class Customer : BaseEntity, IEntity
{
    public int Id { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public string CustomerCity { get; set; } = string.Empty;
    public string CustomerPhone { get; set; } = string.Empty;

}
