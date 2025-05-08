using Microsoft.AspNetCore.SignalR;
using SignalRServer.Hubs;

namespace SignalRServer.Services
{
    public class NotificationService(IHubContext<NotificationHub, IStubNotification> hubContext)
    {
        public async Task SendNotification(string userId, string message)
        {
            if (string.IsNullOrEmpty(userId))
                return;
            await hubContext.Clients.Group($"USER-{userId}").ReceiveNotification(message);
        }
    }
}
