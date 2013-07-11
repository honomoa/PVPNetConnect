using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PVPNetConnect.RiotObjects.Platform.Game.Map
{

public class GameMap : RiotGamesObject
{
public override string TypeName
{
get
{
return this.type;
}
}

private string type = "com.riotgames.platform.game.map.GameMap";

public GameMap()
{
}

public GameMap(Callback callback)
{
this.callback = callback;
}

public GameMap(TypedObject result)
{
base.SetFields(this, result);
}

public delegate void Callback(GameMap result);

private Callback callback;

public override void DoCallback(TypedObject result)
{
base.SetFields(this, result);
callback(this);
}

[InternalName("displayName")]
public String DisplayName { get; set; }

[InternalName("name")]
public String Name { get; set; }

[InternalName("mapId")]
public Int32 MapId { get; set; }

[InternalName("minCustomPlayers")]
public Int32 MinCustomPlayers { get; set; }

[InternalName("totalPlayers")]
public Int32 TotalPlayers { get; set; }

[InternalName("description")]
public String Description { get; set; }

}
}
