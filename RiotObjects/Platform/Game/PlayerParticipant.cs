using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PVPNetConnect.RiotObjects.Platform.Game
{

public class PlayerParticipant : RiotGamesObject
{
public override string TypeName
{
get
{
return this.type;
}
}

private string type = "com.riotgames.platform.game.PlayerParticipant";

public PlayerParticipant(Callback callback)
{
this.callback = callback;
}

public PlayerParticipant(TypedObject result)
{
base.SetFields(this, result);
}

public delegate void Callback(PlayerParticipant result);

private Callback callback;

public override void DoCallback(TypedObject result)
{
base.SetFields(this, result);
callback(this);
}

[InternalName("timeAddedToQueue")]
public double TimeAddedToQueue { get; set; }

[InternalName("index")]
public int Index { get; set; }

[InternalName("queueRating")]
public int QueueRating { get; set; }

[InternalName("accountId")]
public double AccountId { get; set; }

[InternalName("botDifficulty")]
public string BotDifficulty { get; set; }

[InternalName("originalAccountNumber")]
public double OriginalAccountNumber { get; set; }

[InternalName("summonerInternalName")]
public string SummonerInternalName { get; set; }

[InternalName("minor")]
public bool Minor { get; set; }

[InternalName("locale")]
public object Locale { get; set; }

[InternalName("lastSelectedSkinIndex")]
public int LastSelectedSkinIndex { get; set; }

[InternalName("partnerId")]
public string PartnerId { get; set; }

[InternalName("profileIconId")]
public int ProfileIconId { get; set; }

[InternalName("teamOwner")]
public bool TeamOwner { get; set; }

[InternalName("summonerId")]
public double SummonerId { get; set; }

[InternalName("badges")]
public int Badges { get; set; }

[InternalName("pickTurn")]
public int PickTurn { get; set; }

[InternalName("clientInSynch")]
public bool ClientInSynch { get; set; }

[InternalName("summonerName")]
public string SummonerName { get; set; }

[InternalName("pickMode")]
public int PickMode { get; set; }

[InternalName("originalPlatformId")]
public string OriginalPlatformId { get; set; }

[InternalName("teamParticipantId")]
public object TeamParticipantId { get; set; }

}
}
