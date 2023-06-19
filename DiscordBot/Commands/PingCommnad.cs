using System.Threading.Tasks;
using Discord.Commands;

namespace DiscordBot.Commands
{
    public class PingCommand : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        public async Task PingAsync()
        {
            await ReplyAsync("Pong!");
        }
    }
}