using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PVPNetConnect.RiotObjects.Game
{
    public class GameTypeConfigDTO : RiotGamesObject
    {
        public GameTypeConfigDTO(TypedObject result)
        {
            base.SetFields<GameTypeConfigDTO>(this, result);
        }

        [InternalName("id")]
        public int Id { get; set; }

        [InternalName("allowTrades")]
        public bool AllowTrades { get; set; }

        [InternalName("name")]
        public string Name { get; set; }

        [InternalName("mainPickTimerDuration")]
        public int MainPickTimerDuration { get; set; }

        [InternalName("exclusivePick")]
        public bool ExclusivePick { get; set; }

        [InternalName("pickMode")]
        public string PickMode { get; set; }

        [InternalName("maxAllowableBans")]
        public int MaxAllowableBans { get; set; }

        [InternalName("banTimerDuration")]
        public int BanTimerDuration { get; set; }

        [InternalName("postPickTimerDuration")]
        public int PostPickTimerDuration { get; set; }
    }
}
