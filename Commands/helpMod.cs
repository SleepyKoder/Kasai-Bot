using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace Kasaibot.Commands
{
    public class helpMod : ModuleBase<SocketCommandContext>
    {
        EmbedBuilder Embed = new EmbedBuilder();
        [Command("help")]
        public async Task help([Remainder]string message)
        {
            Embed.WithAuthor("~Kasai~");
            Embed.WithColor(new Color(127, 255, 0));
            Embed.WithDescription("Visit the link for the bot's documentation and all the help you would ever need");
            Embed.WithUrl("https://github.com/SleepyKoder/Kasai-Bot");
        }
    }
}
