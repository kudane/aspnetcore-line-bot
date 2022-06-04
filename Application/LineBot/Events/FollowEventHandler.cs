using Application.LineBot.Interfaces;
using Line;

namespace Application.LineBot.Events
{
    public class FollowEventHandler: IEventHandler
    {
        public LineEventType EventType => LineEventType.Follow;

        public async Task HandleAsync(ILineBot lineBot, ILineEvent evt)
        {
            throw new NotImplementedException();
        }
    }
}
