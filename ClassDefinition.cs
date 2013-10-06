using System.Collections.Generic;

namespace PVPThreatConnect
{
	public class ClassDefinition
	{
		public string type;
		public bool externalizable = false;
		public bool dynamic = false;
		public List<string> members = new List<string>();
	}
}
