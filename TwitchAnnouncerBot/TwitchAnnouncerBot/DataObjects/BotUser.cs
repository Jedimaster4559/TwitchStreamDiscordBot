using System;
using System.Collections.Generic;
using System.Text;

namespace TwitchAnnouncerBot.DataObjects
{
    public class BotUser : DiscordEntity
    {
        

        public BotUser(long id, string name) : base(id, name)
        {
            
        }
    }
}
