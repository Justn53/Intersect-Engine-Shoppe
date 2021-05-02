using MessagePack;
using System;

namespace Intersect.Network.Packets.Client
{
    [MessagePackObject]
    public class DropItemPacket : SlotQuantityPacket
    {
        //Parameterless Constructor for MessagePack
        public DropItemPacket() : base( 0, 0 )
        {
        }

        public DropItemPacket(int slot, int quantity, Guid mapId, int tileIndex, int mouseIndex) : base(slot, quantity)
        {
            MapId = mapId;
            TileIndex = tileIndex;
            MouseIndex = mouseIndex;
        }

        [Key( 4 )]
        public Guid MapId { get; set; }

        [Key( 5 )]
        public int TileIndex { get; set; }

        [Key( 6 )]
        public int MouseIndex { get; set; }

    }

}
