using System.Diagnostics;

namespace MediatR_Basic.Services;

public interface INotifierMediatorService
{
    void Notify();
}

public class NotifierMediatorService : INotifierMediatorService
{
    private readonly IEnumerable<INotifier> _notifiers;

    public NotifierMediatorService(IEnumerable<INotifier> notifiers)
    {
        _notifiers = notifiers;
    }

    public void Notify()
    {
        _notifiers.ToList().ForEach(x => x.Notify());
    }
}


public interface INotifier
{
    void Notify();
    bool CanRun();
}

public class Notifier1 : INotifier
{
    public void Notify()
    {
        Debug.WriteLine("Debugging from Notifier 1");
    }

    public bool CanRun()
    {
        //Check something. And return True if it can run. 
        return true;
    }
}

public class Notifier2 : INotifier
{
    public void Notify()
    {
        Debug.WriteLine("Debugging from Notifier 2");
    }

    public bool CanRun()
    {
        //Check something. And return True if it can run. 
        return false;
    }
}