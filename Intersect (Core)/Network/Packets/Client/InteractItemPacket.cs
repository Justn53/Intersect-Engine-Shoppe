using MessagePack;
using System;

namespace Intersect.Network.Packets.Client
{
    [MessagePackObject]
    public class InteractItemPacket : IntersectPacket
    {
        public InteractItemPacket()
        {
        }

        public InteractItemPacket( Guid mapId, int tileIndex, int mouseIndex, Guid uniqueId )
        {
            MapId = mapId;
            UniqueId = uniqueId;
            TileIndex = tileIndex;
            MouseIndex = mouseIndex;
        }

        [Key( 0 )]
        public Guid UniqueId { get; set; }

        [Key( 1 )]
        public Guid MapId { get; set; }

        [Key( 2 )]
        public int TileIndex { get; set; }

        [Key( 3 )]
        public int MouseIndex { get; set; }
    }
}
