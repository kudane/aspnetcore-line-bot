using Application.LineBot.Guards;
using Application.LineBot.Interfaces;
using System.Text;

namespace Application.LineBot.Logger
{
    public class LoggerHandler : ILineLogger
    {
        public async Task LogApiCall(Uri uri, HttpContent httpContent)
        {
            var postedData = string.Empty;
            if (httpContent != null)
            {
                var bytes = await httpContent.ReadAsByteArrayAsync();
                postedData = $"PostedData: {Encoding.UTF8.GetString(bytes)}{Environment.NewLine}";
            }

            Console.WriteLine($"Request to: {uri}{Environment.NewLine}{postedData}");
        }

        public Task LogReceivedEvents(byte[] eventsData)
        {
            Console.WriteLine($"Events received: {Encoding.UTF8.GetString(eventsData)}");

            return Task.CompletedTask;
        }

        public Task LogExceptionEvents(GuardException exception)
        {
            Console.WriteLine($"Events received: {exception.message}");

            return Task.CompletedTask;
        }
    }
}
