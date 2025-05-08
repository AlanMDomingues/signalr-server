namespace SignalRServer.Hubs
{
    public interface IStubNotification
    {
        Task ReceiveNotification(string message);
    }
}
