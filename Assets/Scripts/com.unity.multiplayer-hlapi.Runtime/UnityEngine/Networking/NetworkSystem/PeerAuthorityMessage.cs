using System;

namespace UnityEngine.Networking.NetworkSystem
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class PeerAuthorityMessage : MessageBase
	{
		public int connectionId;

		public NetworkInstanceId netId;

		public bool authorityState;

		public override void Deserialize(NetworkReader reader)
		{
			connectionId = (int)reader.ReadPackedUInt32();
			netId = reader.ReadNetworkId();
			authorityState = reader.ReadBoolean();
		}

		public override void Serialize(NetworkWriter writer)
		{
			writer.WritePackedUInt32((uint)connectionId);
			writer.Write(netId);
			writer.Write(authorityState);
		}
	}
}
