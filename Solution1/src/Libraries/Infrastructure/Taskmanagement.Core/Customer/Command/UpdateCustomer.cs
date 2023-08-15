using AutoMapper;
using MediatR;
using Taskmanagement.Model;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.Customer.Command;

public record UpdateCustomer(int Id, VmCustomer VmCustomer) : IRequest<VmCustomer>;

public class UpdateCustomerHandler : IRequestHandler<UpdateCustomer, VmCustomer>
{
    private readonly ICustomerRepository _customerRepository;
    private readonly IMapper _mapper;

    public UpdateCustomerHandler(ICustomerRepository customerRepository, IMapper mapper)
    {
        _customerRepository = customerRepository;
        _mapper = mapper;

    }

    public async Task<VmCustomer> Handle(UpdateCustomer request, CancellationToken cancellationToken)
    {
        var data = _mapper.Map<Model.Customer>(request.VmCustomer);
        return await _customerRepository.Update(request.Id, data);
    }
}



