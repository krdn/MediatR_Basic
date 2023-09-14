using System.Diagnostics;

namespace MediatR_Basic.Services;

class MyService
{
    private readonly Handler1 _handler1;
    private readonly Handler2 _handler2;
    private readonly Handler3 _handler3;


    public MyService(Handler1 handler1, Handler2 handler2, Handler3 handler3)
    {
        _handler1 = handler1;
        _handler2 = handler2;
        _handler3 = handler3;
    }

    public void DoSomething()
    {
        //Do something here. 
        //And do some more work

        //And then notify our handlers. 
        _handler1.Notify(new HandlerArgs());
        _handler2.Notify(new HandlerArgs());
        _handler3.Notify(new HandlerArgs());
    }
}

public class HandlerArgs
{
    public HandlerArgs()
    {
    }
}

public class Handler3
{
    public void Notify(HandlerArgs handlerArgs)
    {
        Debug.WriteLine("Debugging from Notifier 3");
    }
}

public class Handler2
{
    public void Notify(HandlerArgs handlerArgs)
    {
        Debug.WriteLine("Debugging from Notifier 2");
    }
}

public class Handler1
{
    internal void Notify(HandlerArgs handlerArgs)
    {
        Debug.WriteLine("Debugging from Notifier 1");
    }
}