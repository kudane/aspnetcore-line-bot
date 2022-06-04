using Application.LineBot.Interfaces;
using Line;

namespace Application.LineBot.Events
{
    public class LeaveEventHandler : IEventHandler
    {
        public LineEventType EventType => LineEventType.Leave;

        public async Task HandleAsync(ILineBot lineBot, ILineEvent evt)
        {
            throw new NotImplementedException();
        }
    }
}
