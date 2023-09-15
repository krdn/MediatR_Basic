using MediatR;
using System.Diagnostics;

namespace MediatR_Basic.Services.MediatR;


public interface INotifierMediatRService
{
    void Notify(string notifyText);
}

public class NotifierMediatRService : INotifierMediatRService
{
    private readonly IMediator _mediator;

    public NotifierMediatRService(IMediator mediator)
    {
        _mediator = mediator;
    }

    public void Notify(string notifyText)
    {
        _mediator.Publish(new NotificationMessage { NotifyText = notifyText });
    }
}

