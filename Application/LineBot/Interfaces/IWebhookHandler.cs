namespace Application.LineBot.Interfaces
{
    public interface IWebhookHandler
    {
        Task HandleAsync(HttpContext context);
    }
}
