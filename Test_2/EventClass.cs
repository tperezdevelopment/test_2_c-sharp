using System;


public class MyEventArguments : EventArgs
{
    public string Message { get; set; }

    public MyEventArguments(string message)
    {
        Message = message;
    }
}

public delegate void MyEventHandler(object sender, MyEventArguments e);

public class ClassEvent
{
    public event MyEventHandler MyEvent;

    public void ThroughEvent(string message)
    {
        MyEvent?.Invoke(this, new MyEventArguments(message));
    }
}

public class MyManagerEvent
{
    public void ManagerEvent(object sender, MyEventArguments e)
    {
        Console.WriteLine($"The Manager event speaking: {e.Message}");
    }
}

class Program
{
    static void Main()
    {
        ClassEvent classEvent = new ClassEvent();
        MyManagerEvent managerEvent = new MyManagerEvent();

        classEvent.MyEvent += managerEvent.ManagerEvent;

        classEvent.ThroughEvent("This is the message");



    }
}



