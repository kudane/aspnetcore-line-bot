using Line;

namespace Application.LineBot.Interfaces
{
    public interface ICaseHandler
    {
        string CaseName { get; }
        Task HandleAsync(ILineBot lineBot, ILineEvent evt);
    }
}
