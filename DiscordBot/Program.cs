using System;
using System.Threading.Tasks;

namespace DiscordBot
{
    class Program
    {
        static void Main(string[] args)
        {
            new Bot().RunBotAsync().GetAwaiter().GetResult();
        }
    }
}
