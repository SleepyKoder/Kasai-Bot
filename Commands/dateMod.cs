using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasaibot.Commands
{
    public class dateMod : ModuleBase<SocketCommandContext>
    {
        [Command("date")]
        public async Task date()
        {
            EmbedBuilder Embed = new EmbedBuilder();
            string DateNow = DateTime.Now.ToString("dd-MM-yyyy");
            Embed.WithAuthor("~ Kasai ~");
            Embed.WithColor(new Color(255, 127, 80));
            Embed.WithDescription("Today is: " + DateNow);
            await Context.Channel.SendMessageAsync("", false, Embed.Build());
        }
    }
}
