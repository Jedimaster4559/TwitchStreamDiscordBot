using System;
using System.Collections.Generic;
using System.Text;

namespace TwitchAnnouncerBot.DataObjects
{
    public class EntityList
    {
        List<DiscordEntity> entities { get; set; }

        public EntityList()
        {

        }

        public void add(DiscordEntity entity)
        {
            entities.Add(entity);
        }

        public void remove(DiscordEntity entity)
        {
            entities.Remove(entity);
        }

        public void addStream(TwitchStream stream, long entityID)
        {
            if (!entities.Contains(entity))
            {
                throw new EntityNotFoundException();
            }
            else
            {
                DiscordEntity entity = entities[entities.IndexOf(entity)];
            }
        }

        public void removeStream(TwitchStream stream, DiscordEntity entity)
        {

        }

        private DiscordEntity getEntity(long entityID)
        {

            foreach(DiscordEntity entity in entities)
            {
                if(entity.getID() == entityID)
                {
                    return entity;
                }
            }

            return null;
        }
    }
}
