using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PVPNetConnect.RiotObjects.Platform.Catalog.Champion
{

public class ChampionDTO : RiotGamesObject
{
public override string TypeName
{
get
{
return this.type;
}
}

private string type = "com.riotgames.platform.catalog.champion.ChampionDTO";

public ChampionDTO(Callback callback)
{
this.callback = callback;
}

public ChampionDTO(TypedObject result)
{
base.SetFields(this, result);
}

public delegate void Callback(ChampionDTO result);

private Callback callback;

public override void DoCallback(TypedObject result)
{
base.SetFields(this, result);
callback(this);
}

[InternalName("purchased")]
public double Purchased { get; set; }

[InternalName("championSkins")]
public List<ChampionSkinDTO> ChampionSkins { get; set; }

[InternalName("rankedPlayEnabled")]
public bool RankedPlayEnabled { get; set; }

[InternalName("purchaseDate")]
public double PurchaseDate { get; set; }

[InternalName("winCountRemaining")]
public int WinCountRemaining { get; set; }

[InternalName("botEnabled")]
public bool BotEnabled { get; set; }

[InternalName("active")]
public bool Active { get; set; }

[InternalName("endDate")]
public double EndDate { get; set; }

[InternalName("freeToPlay")]
public bool FreeToPlay { get; set; }

[InternalName("championId")]
public int ChampionId { get; set; }

[InternalName("freeToPlayReward")]
public bool FreeToPlayReward { get; set; }

[InternalName("owned")]
public bool Owned { get; set; }

}
}
