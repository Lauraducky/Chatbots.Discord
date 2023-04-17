using Chatbots.Discord.Services;
using GlobalX.ChatBots.Core.Messages;
using GlobalX.ChatBots.Core.People;
using GlobalX.ChatBots.Core.Rooms;
using Microsoft.Extensions.DependencyInjection;

namespace Chatbots.Discord;

public static class Extensions
{
    public static IServiceCollection ConfigureDiscordBot(this IServiceCollection services)
    {
        services.AddTransient<IMessageHandler, DiscordMessageHandler>();
        services.AddTransient<IPersonHandler, DiscordPersonHandler>();
        services.AddTransient<IRoomHandler, DiscordRoomHandler>();
        return services;
    }
}