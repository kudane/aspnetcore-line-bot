namespace Application.LineBot.Guards
{
    public class GuardException : Exception
    {
        public string message { get; }

        public GuardException(string message)
        {
            this.message = message;
        }
    }
}
