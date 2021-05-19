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
        private static List<EventCommand> PreProcessedEvents = new List<EventCommand>();

        public static void PreProcessEvent(Event newEvent, Player player)
        {
            if (newEvent == null || player == null)
                return;

            var pageInstance = newEvent.PageInstance.MyPage;
            foreach (var command in pageInstance.CommandLists)
            {
                foreach (var commandInstance in command.Value)
                {
                    if (commandInstance == null)
                        continue;

                    if (commandInstance.GetType() == typeof(ReplaceItemCommand))
                    {
                        var replaceItemCommand = (ReplaceItemCommand)commandInstance;
                        replaceItemCommand.StoredPlayerId = player.Id;
                        replaceItemCommand.StoredPlayerX = player.X;
                        replaceItemCommand.StoredPlayerY = player.Y;
                        replaceItemCommand.StoredDirection = player.Dir;
                        replaceItemCommand.MapId = player.MapId;
                        PreProcessedEvents.Add(replaceItemCommand);
                    }

                    if (commandInstance.GetType() == typeof(RemoveItemCommand))
                    {
                        var removeItemCommand = (RemoveItemCommand)commandInstance;
                        removeItemCommand.StoredPlayerId = player.Id;
                        removeItemCommand.StoredPlayerX = player.X;
                        removeItemCommand.StoredPlayerY = player.Y;
                        removeItemCommand.StoredDirection = player.Dir;
                        removeItemCommand.MapId = player.MapId;
                        PreProcessedEvents.Add(removeItemCommand);
                    }
                }
            }
        }

        public static void RemovedProcessedEvent(EventCommand commandInstance, Player player)
        {
            if (commandInstance != null && commandInstance.GetType() == typeof(ReplaceItemCommand))
            {
                var replaceItemCommand = (ReplaceItemCommand)commandInstance;
                if (replaceItemCommand.StoredPlayerId == player.Id)
                    PreProcessedEvents.Remove(replaceItemCommand);
            }

            if (commandInstance != null && commandInstance.GetType() == typeof(RemoveItemCommand))
            {
                var removeItemCommand = (RemoveItemCommand)commandInstance;
                if (removeItemCommand.StoredPlayerId == player.Id)
                    PreProcessedEvents.Remove(removeItemCommand);

            }
        }

        public static void RemovedProcessedEventsExceptForCommandsInStack(CommandInstance tmpStack, Player player)
        {
            var commandsToKeep = new List<EventCommand>();
            foreach (var commandInstance in tmpStack.CommandList)
            {
                foreach (var preProcessedEvent in PreProcessedEvents)
                {
                    if (preProcessedEvent.Type == commandInstance.Type)
                    {
                        if (commandInstance != null && commandInstance.GetType() == typeof(ReplaceItemCommand))
                        {
                            var replaceItemCommand = (ReplaceItemCommand)commandInstance;
                            if (replaceItemCommand.StoredPlayerId == player.Id)
                                commandsToKeep.Add(preProcessedEvent);
                        }

                        if (commandInstance != null && commandInstance.GetType() == typeof(RemoveItemCommand))
                        {
                            var removeItemCommand = (RemoveItemCommand)commandInstance;
                            if (removeItemCommand.StoredPlayerId == player.Id)
                                commandsToKeep.Add(preProcessedEvent);
                        }

                    }

                }
            }

            PreProcessedEvents = commandsToKeep;
        }
    }
}
