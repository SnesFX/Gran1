using System;

namespace UnityEngine.Networking.NetworkSystem
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class ReconnectMessage : MessageBase
	{
		public int oldConnectionId;

		public short playerControllerId;

		public NetworkInstanceId netId;

		public int msgSize;

		public byte[] msgData;

		public override void Deserialize(NetworkReader reader)
		{
			oldConnectionId = (int)reader.ReadPackedUInt32();
			playerControllerId = (short)reader.ReadPackedUInt32();
			netId = reader.ReadNetworkId();
			msgData = reader.ReadBytesAndSize();
			msgSize = msgData.Length;
		}

		public override void Serialize(NetworkWriter writer)
		{
			writer.WritePackedUInt32((uint)oldConnectionId);
			writer.WritePackedUInt32((uint)playerControllerId);
			writer.Write(netId);
			writer.WriteBytesAndSize(msgData, msgSize);
		}
	}
}
