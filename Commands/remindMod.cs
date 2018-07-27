using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.Webhook;

namespace Kasaibot.Commands
{
    public class remindMod : ModuleBase<SocketCommandContext>
    {
        [Command("remind")]
        public async Task remind([Remainder]string message)
        {
            EmbedBuilder Embed = new EmbedBuilder();
            DateTime.Now.ToString("dd-MM-yyyy");
            DateTime.Now.ToString("hh:mm" + " " + "tt", CultureInfo.InvariantCulture);
            string[] msgbreak = message.Split(',');
            DateTime timeNow = DateTime.Now;


            int timeValue = Int32.Parse(msgbreak[0]);
            
            if (msgbreak[1] == "minutes" || msgbreak[1] == "minute")
            {
                timeNow.AddMinutes(timeValue);
                string timeAlarmMin = timeNow.ToString();
                Embed.WithAuthor("~ Kasai ~");
                Embed.WithColor(new Color(255, 127, 80));
                Embed.WithDescription("Alarm has been set for" + timeAlarmMin);
            }
            if (msgbreak[1] == "hours" || msgbreak[1] == "hour")
            { 
                timeNow.AddHours(timeValue);
                string timeAlarmHour = timeNow.ToString();
                Embed.WithAuthor("~ Kasai ~");
                Embed.WithColor(new Color(255, 127, 80));
                Embed.WithDescription("Alarm has been set for" + timeAlarmHour);
            }



            await Context.Channel.SendMessageAsync("", false, Embed.Build());

        }
    }
}
