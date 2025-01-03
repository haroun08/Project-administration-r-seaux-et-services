using MediatR;
using Microsoft.AspNetCore.Mvc;
using Orders.Domain.Entities;
using Orders.Service.Application.Commands;
using Orders.Service.Application.Queries;

namespace Orders.Service.Controllers;

[Route("orders")]
[ApiController]
public class OrdersController : ControllerBase 
{
    private readonly IMediator _mediator;

    public OrdersController(IMediator mediator) 
    {
        _mediator = mediator;
    }
    [HttpPost]
    public async Task<int> CreateOrder(CreateOrderCommand request) 
    {
        return await _mediator.Send(request);
    }
    [HttpGet]
    public async Task<Order> GetOrder(GetOrderQuery request) 
    {
        return await _mediator.Send(request);
    }
}