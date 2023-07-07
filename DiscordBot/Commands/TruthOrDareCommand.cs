using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Discord.Commands;

namespace DiscordBot.Commands
{
    public class TruthOrDareCommand : ModuleBase<SocketCommandContext>
    {
        private static Random _random = new Random();

        private List<string> _truths = new List<string>
{
    "Mik a három kedvenc filmjeid?",
    "Mi a legviccesebb emléked a gyerekkorodból?",
    "Mi volt a legnagyobb félelmed, ami kiderült, hogy alaptalan volt?",
    "Mi a legfurcsább szokásod?",
    "Mi volt a legrosszabb randi élményed?",
    "Mi a legkínosabb helyzet, amiben valaha voltál?",
    "Mi a legőrültebb álmod, amit valaha láttál?",
    "Mi az a dolog, amit a legjobban sajnálsz az életedben?",
    "Mi az a dolog, amit legszívesebben változtatnál magadon?",
    "Mi a legcikibb dolog, amit valaha csináltál a nyilvánosság előtt?",
    "Mi volt az első gondolatod ma reggel?",
    "Mi a legfurcsább étel, amit valaha ettél?",
    "Mi a legnevetségesebb dolog, ami miatt valaha sírtál?",
    "Mi volt az utolsó könyv, amit olvastál, és miért tetszett neked?",
    "Mi a legnagyobb félelmed a jövővel kapcsolatban?",
    "Mi a legboldogabb emléked az életedből?",
    "Mi a legnagyobb álmod a jövővel kapcsolatban?",
    "Mi az a dolog, amit a leginkább sajnálsz az életedben?",
    "Mi volt az utolsó vicc, amit hallottál, és nagyon megnevettetett?",
    "Mi az a dolog, amit soha nem tennél meg?",
    "Mi a legviccesebb dolog, ami valaha veled történt?",
    "Mi a legcsodálatosabb hely, ahol valaha jártál?",
    "Mi a legőrültebb álmod, amit valaha láttál?",
    "Mi az a dolog, amit a legjobban szeretsz magadban?",
    "Mi az a dolog, amit a legjobban szeretsz a barátaidban?",
    "Mi volt a legromantikusabb élményed?",
    "Mi az a dolog, amit a legtöbb ember nem tud rólad?",
    "Mi az a dolog, amit legszívesebben kipróbálnál, de még soha nem merted?",
    "Mi az a dolog, amit legszívesebben elfelejtenél az életedből?",
    "Mi volt az első gondolatod, amikor felébredtél ma reggel?",
    "Mi a legérdekesebb tény, amit mostanában hallottál?",
    "Mi a legnagyobb baklövést követted el a múlt hónapban?",
    "Mi a legboldogabb pillanatod az elmúlt hónapban?",
    "Mi az a dolog, amit a leginkább vársz az elkövetkező hónapokban?",
    "Mi a legfurcsább dolog, ami valaha veled történt egy buliban?",
    "Mi a legkülönlegesebb hely, ahol valaha jártál?",
    "Mi az a dolog, amit a legkevesebben tudnak rólad?",
    "Mi volt a legizgalmasabb kirándulásod, és miért volt az különleges?",
    "Mi az a dolog, amit legszívesebben visszavonnál az életedből?",
    "Mi az a dolog, amit legszívesebben megtennél az életedben, ha semmit nem kellene félned?",
    "Mi a legviccesebb címlap, amit valaha láttál egy újságban vagy magazinban?",
    "Mi az a dolog, amit legszívesebben mondanál el a jelenlévőknek, de soha nem merted?",
    "Mi a legkínosabb helyzet, amiben valaha voltál a suliban vagy a munkahelyeden?",
    "Mi volt az utolsó dolog, amit megvettél és nagyon boldoggá tett?",
    "Mi az a dolog, amit a legjobban vársz az elkövetkező években?",
    "Mi a legviccesebb emléked a gyerekkorodból?",
};

        private List<string> _dares = new List<string>
{
    "Változtasd meg a Discord profilképedet egy vicces képre!",
    "Mondj egy szerelmet valló mondatot egy véletlenszerű személynek a szervereden!",
    "Ugrálj háromszor a helyeden!",
    "Utánozd a kedvenc hírességed vagy karakteredet!",
    "Kérj meg valakit a szobádban, hogy táncoljon veled!",
    "Énekelj egy dalt a hangodon!",
    "Énekelj el egy dalt a többiek előtt!",
    "Küldj egy vicces gif-et vagy képet a kedvenc mém kategóriádról!",
    "Készíts egy vicces arckifejezést és osszd meg a kamerádon keresztül!",
    "Fogadj el egy kihívást a közösség tagjaitól, és hajtsd végre a szobádban vagy a környezetedben!",
    "Mondj egy viccet a chatben, és próbáld megnevettetni a többieket!",
    "Írj egy vicces rövid történetet a chatben, ami mindenkinek mosolyt csal az arcára!",
    "Táncolj egy vicces táncot a kamerád előtt, és kérj meg másokat is, hogy csatlakozzanak!",
    "Készíts egy vicces hangüzenetet, és osszd meg a chatben!",
    "Igyál meg egy pohár vizet egyetlen egy kortyal!",
    "A következő buliban, kérj meg egy idegent hogy táncoljon veled!",
    "Táncolj a közeli parkban egy padon!",
    "Egyél egy kanál sót!",
    "Ölelj meg egy random idegent az utcán!",
    "Ugrálj össze-vissza tízszer!",
    "Csókolj meg egy fa törzsét!",
    "Feküdj le az út közepére és simulj hozzá!",
    "Ugrálj be a legközelebbi tóba vagy medencébe ruhában!",
    "Mutasd meg a legviccesebb táncodat!",
    "Fújj egy csókot a közeli autókra!",
    "Próbáld megérinteni a saját orrodat a nyelveddel!",
};


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