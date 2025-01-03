using MediatR;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Payments.Domain;
using Payments.Domain.Entities;

namespace Payments.Service.Application.Commands;

public class UpdatePaymentsStatusCommand : IRequest {
    public PaymentStatus Status {get;set;}
    public int Id {get;set;}
    public class UpdatePaymentsStatusCommandHanlder : IRequestHandler<UpdatePaymentsStatusCommand>
    {
        private readonly ApplicationDbContext _dbContext;
        public UpdatePaymentsStatusCommandHanlder(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<Unit> Handle(UpdatePaymentsStatusCommand request, CancellationToken cancellationToken)
        {
            var payment = _dbContext.Payments.First(x => x.Id == request.Id); 
            if(payment.status != PaymentStatus.Pending ){
                throw new Exception("Only the status of Pending payment can get updated");
            }
            payment.status = request.Status;

            _dbContext.SaveChanges();

            return Task.FromResult(Unit.Value);
        }
    }
}