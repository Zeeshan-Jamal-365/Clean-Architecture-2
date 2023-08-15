using AutoMapper;
using MediatR;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.Product.Command;

public record CreateProduct(VmProduct VmProduct) : IRequest<VmProduct>;


public class CreateProductHandler : IRequestHandler<CreateProduct, VmProduct>
{



    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public CreateProductHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }


    public async Task<VmProduct> Handle(CreateProduct request, CancellationToken cancellationToken)
    {
        var data = _mapper.Map<Model.Product>(request.VmProduct);
        return await _productRepository.Add(data);
    }

}

