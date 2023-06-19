using System;
using System.Reflection;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace DiscordBot
{
    class Bot
    {
        private DiscordSocketClient _client;
        private CommandService _commands;
        private IServiceProvider _services;
        private readonly string[] _botPrefixes = new[] { "!", "?", "-" };

        private Task _client_Log(LogMessage arg)
        {
            Console.WriteLine(arg);
            return Task.CompletedTask;
        }

        public async Task RunBotAsync()
        {
            _client = new DiscordSocketClient();
            _commands = new CommandService();
            _services = new ServiceCollection()
                .AddSingleton(_client)
                .AddSingleton(_commands)
                .BuildServiceProvider();

            _client.Log += _client_Log;

            await RegisterCommandsAsync();

            string token = "BOT_TOKEN";
            await _client.LoginAsync(TokenType.Bot, token);

            await _client.StartAsync();

            await Task.Delay(-1);
        }


        public async Task RegisterCommandsAsync()
        {
            _client.MessageReceived += HandleCommandAsync;
            await _commands.AddModulesAsync(Assembly.GetEntryAssembly(), _services);
        }


        private async Task HandleCommandAsync(SocketMessage arg)
        {
            var message = arg as SocketUserMessage;
            var context = new SocketCommandContext(_client, message);

            int argPos = 0;
            string prefix = _botPrefixes.FirstOrDefault(p => message.Content.StartsWith(p));
            if (message.Author.IsBot || prefix == null || !message.HasStringPrefix(prefix, ref argPos)) return;

            var result = await _commands.ExecuteAsync(context, argPos, _services);
            if (!result.IsSuccess)
                Console.WriteLine(result.ErrorReason);
        }
    }
}
