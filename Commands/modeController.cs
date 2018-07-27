using Discord;
using Discord.Commands;
using Discord.Webhook;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasaibot.Commands
{
    public class modes : ModuleBase<SocketCommandContext>
    {
        [Command("mode")]
        public async Task testing()
        {
            string cmode = File.ReadLines("Mode.txt").First();
            if (cmode != "imouto")
            {
                using (StreamWriter newTask = new StreamWriter("Mode.text", false))
                {
                    newTask.WriteLine("imouto");
                }
                await Context.Channel.SendMessageAsync("ehHH, if you say so. I'll do my best for you onii-chan!" + System.Environment.NewLine + "Ganbarimasu  （＾ω＾）");
            }
            else
            {
                await Context.Channel.SendMessageAsync("same as last time");
            }
        }
    }
}
