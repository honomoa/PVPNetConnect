using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PVPNetConnect.RiotObjects.Platform.Systemstate
{

public class ClientSystemStatesNotification : RiotGamesObject
{
public override string TypeName
{
get
{
return this.type;
}
}

private string type = "com.riotgames.platform.systemstate.ClientSystemStatesNotification";

public ClientSystemStatesNotification(Callback callback)
{
this.callback = callback;
}

public ClientSystemStatesNotification(TypedObject result)
{
base.SetFields(this, result);
}

public delegate void Callback(ClientSystemStatesNotification result);

private Callback callback;

public override void DoCallback(TypedObject result)
{
base.SetFields(this, result);
callback(this);
}

[InternalName("championTradeThroughLCDS")]
public bool ChampionTradeThroughLCDS { get; set; }

[InternalName("practiceGameEnabled")]
public bool PracticeGameEnabled { get; set; }

[InternalName("advancedTutorialEnabled")]
public bool AdvancedTutorialEnabled { get; set; }

[InternalName("minNumPlayersForPracticeGame")]
public int MinNumPlayersForPracticeGame { get; set; }

[InternalName("practiceGameTypeConfigIdList")]
public Int32[] PracticeGameTypeConfigIdList { get; set; }

[InternalName("freeToPlayChampionIdList")]
public Int32[] FreeToPlayChampionIdList { get; set; }

[InternalName("inactiveChampionIdList")]
public object[] InactiveChampionIdList { get; set; }

[InternalName("inactiveSpellIdList")]
public Int32[] InactiveSpellIdList { get; set; }

[InternalName("inactiveTutorialSpellIdList")]
public Int32[] InactiveTutorialSpellIdList { get; set; }

[InternalName("inactiveClassicSpellIdList")]
public Int32[] InactiveClassicSpellIdList { get; set; }

[InternalName("inactiveOdinSpellIdList")]
public Int32[] InactiveOdinSpellIdList { get; set; }

[InternalName("inactiveAramSpellIdList")]
public Int32[] InactiveAramSpellIdList { get; set; }

[InternalName("enabledQueueIdsList")]
public Int32[] EnabledQueueIdsList { get; set; }

[InternalName("unobtainableChampionSkinIDList")]
public Int32[] UnobtainableChampionSkinIDList { get; set; }

[InternalName("archivedStatsEnabled")]
public bool ArchivedStatsEnabled { get; set; }

[InternalName("queueThrottleDTO")]
public Dictionary<String, Object> QueueThrottleDTO { get; set; }

[InternalName("gameMapEnabledDTOList")]
public Dictionary<String, Object>[] GameMapEnabledDTOList { get; set; }

[InternalName("storeCustomerEnabled")]
public bool StoreCustomerEnabled { get; set; }

[InternalName("socialIntegrationEnabled")]
public bool SocialIntegrationEnabled { get; set; }

[InternalName("runeUniquePerSpellBook")]
public bool RuneUniquePerSpellBook { get; set; }

[InternalName("tribunalEnabled")]
public bool TribunalEnabled { get; set; }

[InternalName("observerModeEnabled")]
public bool ObserverModeEnabled { get; set; }

[InternalName("spectatorSlotLimit")]
public int SpectatorSlotLimit { get; set; }

[InternalName("clientHeartBeatRateSeconds")]
public int ClientHeartBeatRateSeconds { get; set; }

[InternalName("observableGameModes")]
public String[] ObservableGameModes { get; set; }

[InternalName("observableCustomGameModes")]
public string ObservableCustomGameModes { get; set; }

[InternalName("teamServiceEnabled")]
public bool TeamServiceEnabled { get; set; }

[InternalName("leagueServiceEnabled")]
public bool LeagueServiceEnabled { get; set; }

[InternalName("modularGameModeEnabled")]
public bool ModularGameModeEnabled { get; set; }

[InternalName("riotDataServiceDataSendProbability")]
public int RiotDataServiceDataSendProbability { get; set; }

[InternalName("displayPromoGamesPlayedEnabled")]
public bool DisplayPromoGamesPlayedEnabled { get; set; }

[InternalName("masteryPageOnServer")]
public bool MasteryPageOnServer { get; set; }

[InternalName("maxMasteryPagesOnServer")]
public int MaxMasteryPagesOnServer { get; set; }

[InternalName("tournamentSendStatsEnabled")]
public bool TournamentSendStatsEnabled { get; set; }

[InternalName("replayServiceAddress")]
public string ReplayServiceAddress { get; set; }

[InternalName("kudosEnabled")]
public bool KudosEnabled { get; set; }

[InternalName("buddyNotesEnabled")]
public bool BuddyNotesEnabled { get; set; }

[InternalName("localeSpecificChatRoomsEnabled")]
public bool LocaleSpecificChatRoomsEnabled { get; set; }

[InternalName("replaySystemStates")]
public Dictionary<String, Object> ReplaySystemStates { get; set; }

[InternalName("sendFeedbackEventsEnabled")]
public bool SendFeedbackEventsEnabled { get; set; }

[InternalName("knownGeographicGameServerRegions")]
public String[] KnownGeographicGameServerRegions { get; set; }

[InternalName("leaguesDecayMessagingEnabled")]
public bool LeaguesDecayMessagingEnabled { get; set; }

}
}
