using MediatR;
using System.Diagnostics;

namespace MediatR_Basic.Services.MediatR;

public record NotificationMessage : INotification
{
    public string NotifyText { get; set; }
}

public class Notifier1 : INotificationHandler<NotificationMessage>
{
    public Task Handle(NotificationMessage notification, CancellationToken cancellationToken)
    {
        Debug.WriteLine($"Debugging from Notifier 1. Message  : {notification.NotifyText} ");
        return Task.CompletedTask;
    }
}

public class Notifier2 : INotificationHandler<NotificationMessage>
{
    public Task Handle(NotificationMessage notification, CancellationToken cancellationToken)
    {
        Debug.WriteLine($"Debugging from Notifier 2. Message  : {notification.NotifyText} ");
        return Task.CompletedTask;
    }
}

