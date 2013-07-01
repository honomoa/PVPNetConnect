using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PVPNetConnect.RiotObjects.Platform.Summoner
{

public class Summoner : RiotGamesObject
{
public override string TypeName
{
get
{
return this.type;
}
}

private string type = "com.riotgames.platform.summoner.Summoner";

public Summoner(Callback callback)
{
this.callback = callback;
}

public Summoner(TypedObject result)
{
base.SetFields(this, result);
}

public delegate void Callback(Summoner result);

private Callback callback;

public override void DoCallback(TypedObject result)
{
base.SetFields(this, result);
callback(this);
}

[InternalName("seasonTwoTier")]
public string SeasonTwoTier { get; set; }

[InternalName("internalName")]
public string InternalName { get; set; }

[InternalName("acctId")]
public double AcctId { get; set; }

[InternalName("helpFlag")]
public bool HelpFlag { get; set; }

[InternalName("sumId")]
public double SumId { get; set; }

[InternalName("profileIconId")]
public int ProfileIconId { get; set; }

[InternalName("displayEloQuestionaire")]
public bool DisplayEloQuestionaire { get; set; }

[InternalName("lastGameDate")]
public DateTime LastGameDate { get; set; }

[InternalName("advancedTutorialFlag")]
public bool AdvancedTutorialFlag { get; set; }

[InternalName("revisionDate")]
public DateTime RevisionDate { get; set; }

[InternalName("revisionId")]
public double RevisionId { get; set; }

[InternalName("seasonOneTier")]
public string SeasonOneTier { get; set; }

[InternalName("name")]
public string Name { get; set; }

[InternalName("nameChangeFlag")]
public bool NameChangeFlag { get; set; }

[InternalName("tutorialFlag")]
public bool TutorialFlag { get; set; }

[InternalName("socialNetworkUserIds")]
public List<object> SocialNetworkUserIds { get; set; }

}
}
