using Line;

namespace Application.LineBot.Interfaces
{
    public interface IEventHandler
    {
        LineEventType EventType { get; }
        Task HandleAsync(ILineBot lineBot, ILineEvent evt);
    }
}
