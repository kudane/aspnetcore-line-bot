using Application.LineBot.Interfaces;

namespace Application.LineBot.Guards
{
    public class Guard : IGuardHandler
    {
        public static IGuardHandler Against { get; } = new Guard();

        private Guard() { }
    }
}
