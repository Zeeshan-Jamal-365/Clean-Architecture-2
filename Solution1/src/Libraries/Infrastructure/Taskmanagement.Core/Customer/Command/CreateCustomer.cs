using AutoMapper;
using MediatR;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.Customer.Command;

public record CreateCustomer(VmCustomer VmCustomer) : IRequest<VmCustomer>;


public class CreateCustomerHandler : IRequestHandler<CreateCustomer, VmCustomer>
{



    private readonly ICustomerRepository _customerRepository;
    private readonly IMapper _mapper;

    public CreateCustomerHandler(ICustomerRepository customerRepository, IMapper mapper)
    {
        _customerRepository = customerRepository;
        _mapper = mapper;
    }


    public async Task<VmCustomer> Handle(CreateCustomer request, CancellationToken cancellationToken)
    {
        var data = _mapper.Map<Model.Customer>(request.VmCustomer);
        return await _customerRepository.Add(data);
    }

}

