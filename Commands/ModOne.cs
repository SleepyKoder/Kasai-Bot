using Discord.Commands;
using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasaibot.Modules
{
    public class ModOne : ModuleBase<SocketCommandContext>
    {
        EmbedBuilder Embed = new EmbedBuilder();
        [Command("greentext")]
        public async Task greentext([Remainder]string repeat)      
        {
            Embed.WithAuthor("kek");
            Embed.WithColor(new Color(127, 255, 0));
            Embed.WithDescription("> " + repeat);
            Embed.WithImageUrl (@"https://cdn.discordapp.com/attachments/466959510272081931/469509570516090880/PepeHands.png");
            await Context.Message.DeleteAsync();
            await Context.Channel.SendMessageAsync("", false, Embed.Build());
        }
    }
}
