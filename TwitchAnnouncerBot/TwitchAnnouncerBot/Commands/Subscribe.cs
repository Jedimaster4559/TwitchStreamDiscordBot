using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace TwitchAnnouncerBot
{
    public class Subscribe : ModuleBase<SocketCommandContext>
    {
        [Command("Subscribe")]
        [Alias("subscribe","sub","Sub")]
        public async Task subscribe([Remainder] string twitchChannel)
        {

        }
    }
}
