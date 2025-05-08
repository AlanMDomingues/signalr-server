using Microsoft.AspNetCore.Mvc;
using SignalRServer.Services;

namespace SignalRServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController(NotificationService notificationService) : Controller
    {
        [HttpPost("{clientId}")]
        public async Task<IActionResult> SendNotification(string clientId)
        {
            await notificationService.SendNotification(clientId, "Hello World");
            return Ok("Notification sent");
        }
    }
}
