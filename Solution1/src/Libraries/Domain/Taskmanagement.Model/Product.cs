using Taskmanagement.Shared.Common;

namespace Taskmanagement.Model;

public class Product : BaseEntity, IEntity
{
    public int Id { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public double ProductPrice { get; set; }
    public string ProductModel { get; set; } = string.Empty;
}
