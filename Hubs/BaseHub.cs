using Microsoft.AspNetCore.SignalR;

namespace SignalRServer.Hubs
{
    public abstract class BaseHub<T> : Hub<T> where T : class
    {
        public string UserId => Context.GetHttpContext()?.Request.Query["user_id"].ToString() ?? string.Empty;
    }
}
