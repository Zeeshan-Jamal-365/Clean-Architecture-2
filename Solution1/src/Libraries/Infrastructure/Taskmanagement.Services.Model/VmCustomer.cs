using Taskmanagement.Shared.Common;

namespace Taskmanagement.Services.Model;

public class VmCustomer : IVm
{
    public int Id { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public string CustomerCity { get; set; } = string.Empty;
    public string CustomerPhone { get; set; } = string.Empty;

}
