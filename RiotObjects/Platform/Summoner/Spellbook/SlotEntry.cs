using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PVPNetConnect.RiotObjects.Platform.Summoner;
using PVPNetConnect.RiotObjects.Platform.Catalog.Runes;

namespace PVPNetConnect.RiotObjects.Platform.Summoner.Spellbook
{

public class SlotEntry : RiotGamesObject
{
public override string TypeName
{
get
{
return this.type;
}
}

private string type = "com.riotgames.platform.summoner.spellbook.SlotEntry";

public SlotEntry(Callback callback)
{
this.callback = callback;
}

public SlotEntry(TypedObject result)
{
base.SetFields(this, result);
}

public delegate void Callback(SlotEntry result);

private Callback callback;

public override void DoCallback(TypedObject result)
{
base.SetFields(this, result);
callback(this);
}

[InternalName("runeId")]
public int RuneId { get; set; }

[InternalName("runeSlotId")]
public int RuneSlotId { get; set; }

[InternalName("runeSlot")]
public RuneSlot RuneSlot { get; set; }

[InternalName("rune")]
public Rune Rune { get; set; }

}
}
