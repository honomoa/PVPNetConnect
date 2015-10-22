using System;
using System.Threading.Tasks;

using PVPNetCorrect.RiotObjects.Platform.Summoner;

namespace PVPNetCorrect
{
	public partial class PVPNetConnection
	{
		public async Task<String> PerformLCDSHeartBeat(Int32 arg0, String arg1, Int32 arg2, String arg3)
		{
			int Id = Invoke("loginService", "performLCDSHeartBeat", new object[] { arg0, arg1, arg2, arg3 });
			while (!results.ContainsKey(Id))
				await Task.Delay(10);
			String result = (String)results[Id].GetTO("data")["body"];
			results.Remove(Id);
			return result;
		}

		public void GetSummonerByName(String summonerName, PublicSummoner.Callback callback)
		{
			PublicSummoner cb = new PublicSummoner(callback);
			InvokeWithCallback("summonerService", "getSummonerByName", new object[] { summonerName }, cb);
		}

		public async Task<PublicSummoner> GetSummonerByName(String summonerName)
		{
			int Id = Invoke("summonerService", "getSummonerByName", new object[] { summonerName });
			while (!results.ContainsKey(Id))
				await Task.Delay(10);
			TypedObject messageBody = results[Id].GetTO("data").GetTO("body");
			PublicSummoner result = new PublicSummoner(messageBody);
			results.Remove(Id);
			return result;
		}
	}
}
