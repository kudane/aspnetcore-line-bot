using Application.LineBot.Interfaces;
using Line;

namespace Application.LineBot.Guards
{
    public static class AuthorizeGuard
    {
        public static void Authorize(this IGuardHandler guard, ILineBot lineBot, ILineEvent evt)
        {
            if (false)
            {
                throw new GuardException("Permission Denied");
            }
        }
    }
}
