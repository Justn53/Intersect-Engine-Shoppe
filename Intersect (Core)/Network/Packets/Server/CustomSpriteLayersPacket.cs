using MessagePack;
using System;


namespace Intersect.Network.Packets.Server
{
    [MessagePackObject]
    public class CustomSpriteLayersPacket : IntersectPacket
    {
        //Parameterless Constructor for MessagePack
        public CustomSpriteLayersPacket()
        {
        }

        public CustomSpriteLayersPacket(Guid entityId, string[] customSpriteLayers)
        {
            EntityId = entityId;
            CustomSpriteLayers = customSpriteLayers;
        }

        [Key(0)]
        public string[] CustomSpriteLayers { get; set; }

        [Key(1)]
        public Guid EntityId { get; set; }

    }

}