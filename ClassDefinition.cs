using System.Collections.Generic;

namespace PVPNetConnect
{
	public class ClassDefinition
	{
		public string type;
		public bool externalizable = false;
		public bool dynamic = false;
		public List<string> members = new List<string>();
	}
}
