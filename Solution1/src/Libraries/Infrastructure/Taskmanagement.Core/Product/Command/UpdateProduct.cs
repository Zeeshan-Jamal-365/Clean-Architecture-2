using AutoMapper;
using MediatR;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.Product.Command;

public record UpdateProduct(int Id, VmProduct VmProduct) : IRequest<VmProduct>;

public class UpdateProductHandler : IRequestHandler<UpdateProduct, VmProduct>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public UpdateProductHandler(IProductRepository ProductRepository, IMapper mapper)
    {
        _productRepository = ProductRepository;
        _mapper = mapper;

    }

    public async Task<VmProduct> Handle(UpdateProduct request, CancellationToken cancellation)
    {
        var data = _mapper.Map<Model.Product>(request.VmProduct);
        return await _productRepository.Update(request.Id, data);
    }
}



