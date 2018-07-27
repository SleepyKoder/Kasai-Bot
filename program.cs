using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Kasaibot.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kasaiBot
{
   
    public class program
    {
        static void Main(string[] args)
        => new program().StartAsync().GetAwaiter().GetResult();

        private DiscordSocketClient _client;

        private CommandHandler _handler;

        public async Task StartAsync()
        {
            _client = new DiscordSocketClient();

            await _client.LoginAsync(TokenType.Bot, "NDYyNTM3NzcyODY4MDQyNzUy.Dh-9NQ.BmQvlRvI94FfiLACB4unbSo_YVs");

            _client = new DiscordSocketClient(new DiscordSocketConfig
            {
                LogLevel = LogSeverity.Verbose
            });
            _client.Ready += timer.startTimer;          

            await _client.StartAsync();

            Global.Client = _client;

            _handler = new CommandHandler(_client);
          
            await Task.Delay(-1);
        }      
    }
}
