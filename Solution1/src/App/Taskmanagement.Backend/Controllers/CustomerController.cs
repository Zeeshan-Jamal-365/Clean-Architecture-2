using MediatR;
using Microsoft.AspNetCore.Mvc;
using Taskmanagement.Core.Customer.Command;
using Taskmanagement.Core.Customer.Query;
using Taskmanagement.Services.Model;

namespace Taskmanagement.Backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerController : ControllerBase
{
    private readonly IMediator _mediator;
    public CustomerController(IMediator mediator)
    {
        _mediator = mediator;
    }


    [HttpGet]
    public async Task<ActionResult<VmCustomer>> Get()
    {
        var data = await _mediator.Send(new GetAllCustomerQuery());
        return Ok(data);
    }

    [HttpGet("id")]

    public async Task<ActionResult> Get(int id)
    {
        var data = await _mediator.Send(new GetCustomerById(id));
        return Ok(data);
    }




    [HttpPost]

    public async Task<ActionResult<VmCustomer>> PostAsync([FromBody] VmCustomer vmCustomer)
    {
        var data = await _mediator.Send(new CreateCustomer(vmCustomer));
        return Ok(data);
    }
    [HttpPut("id")]

    public async Task<ActionResult<VmCustomer>> PutAsync(int id, [FromBody] VmCustomer vmCustomer)
    {
        var data = await _mediator.Send(new UpdateCustomer(id, vmCustomer));
        return Ok(data);
    }


    [HttpDelete("id")]

    public async Task<ActionResult<VmCustomer>> DeleteAsync(int id)
    {
        var data = await _mediator.Send(new DeleteCustomer(id));
        return Ok(data);
    }



}
