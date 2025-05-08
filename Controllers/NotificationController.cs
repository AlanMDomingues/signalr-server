using Microsoft.AspNetCore.Mvc;
using SignalRServer.Services;
using System.Threading.Tasks;

namespace SignalRServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : Controller
    {
        public NotificationService _notificationService { get; set; }
        public NotificationController(NotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpPost("{clientId}")]
        public async Task<IActionResult> SendNotification(string clientId)
        {
            await _notificationService.SendNotification(clientId, "Hello World");
            return Ok("Notification sent");
        }
    }
}
