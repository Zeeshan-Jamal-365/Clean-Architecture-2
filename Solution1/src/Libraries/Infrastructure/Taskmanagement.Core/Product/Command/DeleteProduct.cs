using MediatR;
using Taskmanagement.Repositories.Interface;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Core.Product.Command;

public record DeleteProduct(int Id) : IRequest<VmProduct>;
public class DeleteProductHandler : IRequestHandler<DeleteProduct, VmProduct>
{
    public readonly IProductRepository _productRepository;

    public DeleteProductHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<VmProduct> Handle(DeleteProduct request, CancellationToken cancellationToken)
    {
        return await _productRepository.Delete(request.Id);
    }



}


