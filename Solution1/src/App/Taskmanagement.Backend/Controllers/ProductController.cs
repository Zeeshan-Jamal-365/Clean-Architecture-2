using MediatR;
using Microsoft.AspNetCore.Mvc;
using Taskmanagement.Core.Product.Command;
using Taskmanagement.Core.Product.Query;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Backend.Controllers;

[Route("api/[controller]")]
[ApiController]

public class ProductController : ControllerBase
{

    private readonly IMediator _mediator;
    public ProductController(IMediator mediator)
    {
        _mediator = mediator;
    }



    [HttpGet]
    public async Task<ActionResult<VmProduct>> Get()
    {
        var data = await _mediator.Send(new GetAllProductQuery());
        return Ok(data);
    }

    [HttpGet("id")]


    public async Task<ActionResult<VmProduct>> Get(int id)
    {
        var data = await _mediator.Send(new GetProductById(id));

        return Ok(data);
    }

    [HttpPost]

    public async Task<ActionResult<VmProduct>> PostAsync([FromBody] VmProduct vmProduct)
    {
        var data = await _mediator.Send(new CreateProduct(vmProduct));
        return Ok(data);
    }


    [HttpPut("id")]

    public async Task<ActionResult<VmProduct>> PutAsync(int id, [FromBody] VmProduct vmProduct)
    {
        var data = await _mediator.Send(new UpdateProduct(id, vmProduct));
        return Ok(data);
    }

    [HttpDelete("id")]

    public async Task<ActionResult<VmProduct>> DeleteAsync(int id)
    {
        var data = await _mediator.Send(new DeleteProduct(id));
        return Ok(data);
    }


}
