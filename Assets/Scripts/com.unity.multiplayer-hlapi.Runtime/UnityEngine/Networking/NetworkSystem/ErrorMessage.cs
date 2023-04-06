using System;

namespace UnityEngine.Networking.NetworkSystem
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class ErrorMessage : MessageBase
	{
		public int errorCode;

		public override void Deserialize(NetworkReader reader)
		{
			errorCode = reader.ReadUInt16();
		}

		public override void Serialize(NetworkWriter writer)
		{
			writer.Write((ushort)errorCode);
		}
	}
}
