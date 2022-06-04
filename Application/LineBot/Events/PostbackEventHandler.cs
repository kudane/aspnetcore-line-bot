using Application.LineBot.Interfaces;
using Line;

namespace Application.LineBot.Events
{
    public class PostbackEventHandler : IEventHandler
    {
        public LineEventType EventType => LineEventType.Postback;

        public async Task HandleAsync(ILineBot lineBot, ILineEvent evt)
        {
            throw new NotImplementedException();
        }
    }
}
