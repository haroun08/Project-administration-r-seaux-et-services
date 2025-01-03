using MediatR;
using Payments.Domain;
using Payments.Domain.Entities;

namespace Payments.Service.Application.Commands;

public class CreatePaymentCommand : IRequest 
{
    public int ReferenceId { get;set;}
    public int Quantity {get;set;}
    public decimal Price {get;set;}
    public class CreatePaymentCommandHandler : IRequestHandler<CreatePaymentCommand>
    {
        private readonly ApplicationDbContext _dbContext;
        public CreatePaymentCommandHandler(ApplicationDbContext dbContext)

        {
            _dbContext = dbContext;
        }
        public Task<Unit> Handle(CreatePaymentCommand request, CancellationToken cancellationToken)
        {
            var payment = new Payment
            {
                ReferenceId = request.ReferenceId,
                Price = request.Quantity * request.Price

            };
            return Task.FromResult(Unit.Value);
        }
    }
}