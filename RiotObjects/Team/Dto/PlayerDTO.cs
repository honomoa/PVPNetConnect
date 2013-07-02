using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PVPNetConnect.RiotObjects.Team;

namespace PVPNetConnect.RiotObjects.Team.Dto
{

public class PlayerDTO : RiotGamesObject
{
public override string TypeName
{
get
{
return this.type;
}
}

private string type = "com.riotgames.team.dto.PlayerDTO";

public PlayerDTO(Callback callback)
{
this.callback = callback;
}

public PlayerDTO(TypedObject result)
{
base.SetFields(this, result);
}

public delegate void Callback(PlayerDTO result);

private Callback callback;

public override void DoCallback(TypedObject result)
{
base.SetFields(this, result);
callback(this);
}

[InternalName("playerId")]
public Double PlayerId { get; set; }

[InternalName("teamsSummary")]
public List<TeamDTO> TeamsSummary { get; set; }

[InternalName("createdTeams")]
public List<CreatedTeam> CreatedTeams { get; set; }

[InternalName("playerTeams")]
public List<TeamInfo> PlayerTeams { get; set; }

}
}
