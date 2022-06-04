using Application.LineBot.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Application.LineBot.Endpoints
{
    [ApiController]
    [Route("api/[Controller]")]
    public class LineController : ControllerBase
    {
        private readonly IWebhookHandler webhook;

        public LineController(IWebhookHandler webhook)
        {
            this.webhook = webhook;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync()
        {
            await webhook.HandleAsync(HttpContext);
            return Ok();
        }
    }
}
