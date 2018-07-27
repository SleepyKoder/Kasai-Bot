using Discord.Commands;
using Discord.WebSocket;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace kasaiBot
{
    class CommandHandler
    {
        private DiscordSocketClient _client;
        private CommandService _service;

        public CommandHandler(DiscordSocketClient client)
        {
            _client = client;

            _service = new CommandService();

            _service.AddModulesAsync(Assembly.GetEntryAssembly());

            _client.MessageReceived += CommandHandlerAsync;

        }

        public async Task CommandHandlerAsync(SocketMessage arg)
        {            
            var msg = arg as SocketUserMessage;

            if (msg == null)
            return;

            var context = new SocketCommandContext(_client, msg);

            int argPos = 0;
            
            if (msg.HasStringPrefix("!k ", ref argPos))
            { 
                var result = await _service.ExecuteAsync(context, argPos);
                    if (!result.IsSuccess && result.ErrorReason == "Unknown command.")
                    {
                        await context.Channel.SendMessageAsync("uWu onii-chan, I don't think I understand your `syntax` >.<" + System.Environment.NewLine + "(´；Д；`)");
                    }

                    if (!result.IsSuccess && result.ErrorReason == "The input text has too few parameters.")
                    {
                        await context.Channel.SendMessageAsync(">.< onii-chan kono baka, i need you to f-fill me up with your `parameters`" + System.Environment.NewLine + "(〃ω〃)");
                    }

                    if (!result.IsSuccess && result.ErrorReason == "The input text has too many parameters.")
                    {
                        await context.Channel.SendMessageAsync("onii-chan ga ecchi! how can I possibly fit that `parameter` inside me" + System.Environment.NewLine + "(｀・ω・´)");
                    }
            }   
        }
    }
}
