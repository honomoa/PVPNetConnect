using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PVPNetConnect.RiotObjects.Team.Stats;
using PVPNetConnect.RiotObjects.Team;

namespace PVPNetConnect.RiotObjects.Team.Dto
{

public class TeamDTO : RiotGamesObject
{
public override string TypeName
{
get
{
return this.type;
}
}

private string type = "com.riotgames.team.dto.TeamDTO";

public TeamDTO(Callback callback)
{
this.callback = callback;
}

public TeamDTO(TypedObject result)
{
base.SetFields(this, result);
}

public delegate void Callback(TeamDTO result);

private Callback callback;

public override void DoCallback(TypedObject result)
{
base.SetFields(this, result);
callback(this);
}

[InternalName("teamStatSummary")]
public TeamStatSummary TeamStatSummary { get; set; }

[InternalName("status")]
public string Status { get; set; }

[InternalName("tag")]
public string Tag { get; set; }

[InternalName("roster")]
public RosterDTO Roster { get; set; }

[InternalName("lastGameDate")]
public DateTime LastGameDate { get; set; }

[InternalName("modifyDate")]
public DateTime ModifyDate { get; set; }

[InternalName("messageOfDay")]
public object MessageOfDay { get; set; }

[InternalName("teamId")]
public TeamId TeamId { get; set; }

[InternalName("lastJoinDate")]
public DateTime LastJoinDate { get; set; }

[InternalName("secondLastJoinDate")]
public object SecondLastJoinDate { get; set; }

[InternalName("secondsUntilEligibleForDeletion")]
public double SecondsUntilEligibleForDeletion { get; set; }

[InternalName("matchHistory")]
public List<MatchHistorySummary> MatchHistory { get; set; }

[InternalName("name")]
public string Name { get; set; }

[InternalName("thirdLastJoinDate")]
public object ThirdLastJoinDate { get; set; }

[InternalName("createDate")]
public DateTime CreateDate { get; set; }

}
}
