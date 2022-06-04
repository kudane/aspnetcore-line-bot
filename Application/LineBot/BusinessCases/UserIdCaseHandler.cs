using Application.LineBot.Interfaces;
using Line;

namespace Application.LineBot.BusinessCases
{
    public class UserIdCaseHandler : ICaseHandler
    {
        public string CaseName => "user-id";

        public async Task HandleAsync(ILineBot lineBot, ILineEvent evt)
        {
            var response = new TextMessage($"pong");

            await lineBot.Reply(evt.ReplyToken, response);
        }
    }
}
