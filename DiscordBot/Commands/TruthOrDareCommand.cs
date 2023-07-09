using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Discord.Commands;

namespace DiscordBot.Commands
{
    public class TruthOrDareCommand : ModuleBase<SocketCommandContext>
    {


        private static Random _random = new Random();
        private List<string> _truths;
        private List<string> _dares;


        public TruthOrDareCommand()
        {
            LoadTruths();
            LoadDares();
        }

        private void LoadTruths()
        {
            var truthsJson = File.ReadAllText("C:/Users/csont/source/repos/DiscordBot/DiscordBot/Data/questions.json");
            _truths = JsonConvert.DeserializeObject<List<string>>(truthsJson);
        }

        private void LoadDares()
        {
            var daresJson = File.ReadAllText("C:/Users/csont/source/repos/DiscordBot/DiscordBot/Data/dares.json");
            _dares = JsonConvert.DeserializeObject<List<string>>(daresJson);
        }

        [Command("felelsz")]
        public async Task TruthCommand()
        {
            var randomIndex = _random.Next(_truths.Count);
            var truth = _truths[randomIndex];

            await ReplyAsync($"Felelsz: {truth}");
        }

        [Command("mersz")]
        public async Task DareCommand()
        {
            var randomIndex = _random.Next(_dares.Count);
            var dare = _dares[randomIndex];

            await ReplyAsync($"Mersz: {dare}");
        }

    }
}