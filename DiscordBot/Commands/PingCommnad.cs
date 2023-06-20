using Discord.Commands;
using System.Threading.Tasks;

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
