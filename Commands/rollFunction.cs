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
    public class rollFunction : ModuleBase<SocketCommandContext>
    {
        Random rng;
        [Command("roll")]
        public async Task roll(int message)
        {
            rng = new Random();            
            string rollstring = Convert.ToString(rng);
            int max = 0;
            max = (message);
            if (message == null)
            {
                max = 100;
            }
            string msgval = max.ToString();
            int osu = rng.Next(max + 1);
            string rollval = osu.ToString();
            string maxroll = max.ToString();
            await Context.Channel.SendMessageAsync(Context.Message.Author.Mention + " has rolled " + rollval + " out of " + maxroll);
        }

    }
}
