using Application.LineBot.Interfaces;
using Line;

namespace Application.LineBot.Events
{
    public class JoinEventHandler : IEventHandler
    {
        public LineEventType EventType => LineEventType.Join;

        public async Task HandleAsync(ILineBot lineBot, ILineEvent evt)
        {
            throw new NotImplementedException();
        }
    }
}
