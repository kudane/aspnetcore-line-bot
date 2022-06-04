using Application.LineBot.Interfaces;
using Line;

namespace Application.LineBot.Events
{
    public class UnfollowEventHandler : IEventHandler
    {
        public LineEventType EventType => LineEventType.Unfollow;

        public async Task HandleAsync(ILineBot lineBot, ILineEvent evt)
        {
            throw new NotImplementedException();
        }
    }
}
