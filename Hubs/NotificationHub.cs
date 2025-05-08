namespace SignalRServer.Hubs
{
    public class NotificationHub : BaseHub<IStubNotification>
    {
        public override async Task OnConnectedAsync()
        {
            var userId = UserId;

            if (!string.IsNullOrEmpty(userId))
            {
                await Groups.AddToGroupAsync(Context.ConnectionId, $"USER-{userId}");
            }

            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            await base.OnDisconnectedAsync(exception);
        }
    }
}
