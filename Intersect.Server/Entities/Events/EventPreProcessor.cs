using Intersect.GameObjects.Events;
using Intersect.GameObjects.Events.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersect.Server.Entities.Events
{
    public static class EventPreProcessor
    {
        private static List<EventCommand> PreprocessedEvents = new List<EventCommand>();

        public static void PreProcessEvent( Event newEvent, Player player )
        {
            if( newEvent == null || player == null )
                return;

            var pageInstance = newEvent.PageInstance.MyPage;
            foreach( var command in pageInstance.CommandLists )
            {
                foreach( var commandInstance in command.Value )
                {
                    if( commandInstance == null )
                        continue;

                    if( commandInstance.GetType() == typeof( ReplaceItemCommand ) )
                    {
                        var replaceItemCommand = (ReplaceItemCommand)commandInstance;
                        //if( !PreprocessedEvents.Contains( replaceItemCommand.Id ) )
                        //{
                        replaceItemCommand.StoredPlayerX = player.X;
                        replaceItemCommand.StoredPlayerY = player.Y;
                        replaceItemCommand.StoredDirection = player.Dir;
                        replaceItemCommand.MapId = player.MapId;
                        PreprocessedEvents.Add( replaceItemCommand );
                        //}
                    }

                    if( commandInstance.GetType() == typeof( RemoveItemCommand ) )
                    {
                        var removeItemCommand = (RemoveItemCommand)commandInstance;
                        //if( !PreprocessedEvents.Contains( removeItemCommand.Id ) )
                        //{
                        removeItemCommand.StoredPlayerX = player.X;
                        removeItemCommand.StoredPlayerY = player.Y;
                        removeItemCommand.StoredDirection = player.Dir;
                        removeItemCommand.MapId = player.MapId;
                        PreprocessedEvents.Add( removeItemCommand );
                        //}
                    }
                }
            }
        }

        public static void RemovedProcessedEvent( EventCommand commandInstance )
        {
            if( commandInstance != null && commandInstance.GetType() == typeof( ReplaceItemCommand ) )
            {
                var replaceItemCommand = (ReplaceItemCommand)commandInstance;
                PreprocessedEvents.Remove( replaceItemCommand );
            }

            if( commandInstance != null && commandInstance.GetType() == typeof( RemoveItemCommand ) )
            {
                var removeItemCommand = (RemoveItemCommand)commandInstance;
                PreprocessedEvents.Remove( removeItemCommand );

            }
        }


    }
}
