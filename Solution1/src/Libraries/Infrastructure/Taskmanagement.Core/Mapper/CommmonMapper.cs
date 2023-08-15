using AutoMapper;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.Mapper;

public class CommmonMapper : Profile
{

    public CommmonMapper()
    {
        CreateMap<VmProduct, Model.Product>().ReverseMap();
        CreateMap<VmCustomer, Model.Customer>().ReverseMap();
    }


}
