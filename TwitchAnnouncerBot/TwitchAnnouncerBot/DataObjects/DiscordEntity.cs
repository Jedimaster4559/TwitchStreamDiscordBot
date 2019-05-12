using System;
using System.Collections.Generic;
using System.Text;

namespace TwitchAnnouncerBot.DataObjects
{
    public abstract class DiscordEntity
    {
        private long id { get; set; }
        private string name { get; set; }
        List<TwitchStream> subscribedStreams { get; set; }

        public DiscordEntity(long id, string name)
        {
            this.id = id;
            this.name = name;
            subscribedStreams = new List<TwitchStream>();
        }

        public long getID()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        public void addStream(TwitchStream stream)
        {
            subscribedStreams.Add(stream);
        }

        public void removeStream(TwitchStream stream)
        {
            subscribedStreams.Remove(stream);
        }
    }
}
