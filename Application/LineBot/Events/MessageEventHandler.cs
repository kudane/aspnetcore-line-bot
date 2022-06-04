using Application.LineBot.Guards;
using Application.LineBot.Interfaces;
using Line;

namespace Application.LineBot.Events
{
    public class MessageEventHandler : IEventHandler
    {
        private readonly IServiceProvider serviceProvider;

        public MessageEventHandler(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public LineEventType EventType => LineEventType.Message;

        public async Task HandleAsync(ILineBot lineBot, ILineEvent evt)
        {
            Guard.Against.Authorize(lineBot, evt);

            if (string.IsNullOrEmpty(evt.Message?.Text))
                return;

            var caseHandler = serviceProvider
                .GetServices<ICaseHandler>()
                .FirstOrDefault(_ => _.CaseName == evt.Message.Text);

            if (caseHandler != null)
            {
                await caseHandler.HandleAsync(lineBot, evt);
            }
        }
    }
}
