using MediatR;
using Microsoft.AspNetCore.Mvc;
using Orders.Domain.Entities;
using Orders.Service.Application.Queries;

namespace Orders.Service.Controllers;

[Route("products")]
[ApiController]
public class productsController : ControllerBase 
{
    private readonly IMediator _mediator;

    public productsController(IMediator mediator) 
    {
        _mediator = mediator;
    }
    [HttpGet]
    public async Task<List<Product>> GetProducts(GetProductsQuery request) 
    {
        return await _mediator.Send(request);
    }
}