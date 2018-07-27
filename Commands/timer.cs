using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;
using System.Globalization;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace Kasaibot.Core
{
    internal static class timer
    {
        private static Timer loopingTimer;
        private static SocketTextChannel channel;

        internal static Task startTimer()
        {
            //test server id = 462538827089707008
            //test channel id = 464332801546780702
            //SocketGuild socketID = new SocketGuild();broken code to be fixed
            channel = Global.Client.GetGuild(462538827089707008).GetTextChannel(464332801546780702);

            loopingTimer = new Timer()
            {
                Interval = 5000,
                AutoReset = true,
                Enabled = true
            };

            loopingTimer.Elapsed += onTimerTicked;

            return Task.CompletedTask;
        }

        private static async void onTimerTicked(object sender, ElapsedEventArgs e)
        {
            await channel.SendMessageAsync("I ping every 5 seconds" + System.Environment.NewLine + "@everyone");
        }
    }
}
