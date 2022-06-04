using Application.LineBot.Guards;
using Line;

namespace Application.LineBot.Interfaces
{
    public interface ILineLogger: ILineBotLogger
    {
        Task LogExceptionEvents(GuardException exception);
    }
}
