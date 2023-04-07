using System;

namespace UnityEngine.Networking.NetworkSystem
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class IntegerMessage : MessageBase
	{
		public int value;

		public IntegerMessage()
		{
		}

		public IntegerMessage(int v)
		{
			value = v;
		}

		public override void Deserialize(NetworkReader reader)
		{
			value = (int)reader.ReadPackedUInt32();
		}

		public override void Serialize(NetworkWriter writer)
		{
			writer.WritePackedUInt32((uint)value);
		}
	}
}
