using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WithOut_Facade_Design_Pattern.Service.IService;

namespace WithOut_Facade_Design_Pattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService notificationService;

        public NotificationController(INotificationService notificationService)
        {
            this.notificationService = notificationService;
        }

        // POST api/<NotificationController>
        [HttpPost]
        public async Task Post([FromBody] string message)
        {
            await notificationService.SendAsync(message);
        }
    }
}
