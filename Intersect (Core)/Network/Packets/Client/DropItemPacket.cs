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

        public DropItemPacket(int slot, int quantity, Guid mapId, int xLocation, int yLocation) : base(slot, quantity)
        {
            MapId = mapId;
            XLocation = xLocation;
            YLocation = yLocation;
        }

        [Key( 4 )]
        public Guid MapId { get; set; }

        [Key( 5 )]
        public int XLocation { get; set; }

        [Key( 6 )]
        public int YLocation { get; set; }
    }

}
