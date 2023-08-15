using Taskmanagement.Shared.Common;

namespace Taskmanagement.Services.Model;

public class VmProduct : IVm
{
    public int Id { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public double ProductPrice { get; set; }
    public string ProductModel { get; set; } = string.Empty;

}
