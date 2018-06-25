using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaxballHeadlessApp
{
    class BotConfig
    {
        //The name for the room.
        public string RoomName { get; set; }

        //The name for the host player.
        public string PlayerName { get; set; }
       
        //The password for the room (no password if ommited).
        public string Password { get; set; }

        //Max number of players the room accepts.
        public int MaxPlayers { get; set; }

        //If true the room will appear in the room list.
        public bool Public { get; set; }

        public bool WinnerStays { get; set; }

        //GeoLocation override for the room.
        public bool OverrideGeoLoc { get; set; }
        public string GeoCode { get; set; }

        public float GeoLat { get; set; }

        public float GeoLong { get; set; }
    }
}
