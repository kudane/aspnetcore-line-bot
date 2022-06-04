using Application.LineBot.BusinessCases;
using Application.LineBot.Events;
using Application.LineBot.Interfaces;
using Application.LineBot.Logger;
using Application.LineBot.Webhook;
using Line;

namespace Application.LineBot
{
    public static class LineBotSetting
    {
        public static void AddBot(this IServiceCollection services, IConfiguration configuration)
        {
            // reqired
            services
                .AddSingleton<ILineConfiguration, LineConfiguration>(sp => {
                    var lineConfiguration = new LineConfiguration();
                    configuration.GetSection("LineConfiguration").Bind(lineConfiguration);
                    return lineConfiguration;
                })
                .AddSingleton<ILineBot, Line.LineBot>()
                .AddSingleton<ILineLogger, LoggerHandler>()
                .AddSingleton<IWebhookHandler, WebhookHandler>();

            // specify by unsed
            services
                .AddSingleton<IEventHandler, FollowEventHandler>()
                .AddSingleton<IEventHandler, JoinEventHandler>()
                .AddSingleton<IEventHandler, LeaveEventHandler>()
                .AddSingleton<IEventHandler, MessageEventHandler>()
                .AddSingleton<IEventHandler, PostbackEventHandler>()
                .AddSingleton<IEventHandler, UnfollowEventHandler>();

            // add-on by bussiness case
            services
                .AddSingleton<ICaseHandler, UserIdCaseHandler>();
        }
    }
}
