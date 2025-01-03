using MediatR;

namespace Notification.Service.Application.Commands;

public class PushNotificationCommand : IRequest
{
    public string Message {get;set;}
    public class PushNotificationCommandHandler : IRequestHandler<PushNotificationCommand>
    {
        public Task<Unit> Handle(PushNotificationCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}