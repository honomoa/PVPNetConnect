using System;
using System.Threading.Tasks;

namespace PVPThreatConnect
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
	}
}
