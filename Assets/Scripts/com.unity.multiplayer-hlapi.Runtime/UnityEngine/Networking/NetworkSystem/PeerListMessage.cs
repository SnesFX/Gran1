using System;

namespace UnityEngine.Networking.NetworkSystem
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class PeerListMessage : MessageBase
	{
		public PeerInfoMessage[] peers;

		public int oldServerConnectionId;

		public override void Deserialize(NetworkReader reader)
		{
			oldServerConnectionId = (int)reader.ReadPackedUInt32();
			int num = reader.ReadUInt16();
			peers = new PeerInfoMessage[num];
			for (int i = 0; i < peers.Length; i++)
			{
				PeerInfoMessage peerInfoMessage = new PeerInfoMessage();
				peerInfoMessage.Deserialize(reader);
				peers[i] = peerInfoMessage;
			}
		}

		public override void Serialize(NetworkWriter writer)
		{
			writer.WritePackedUInt32((uint)oldServerConnectionId);
			writer.Write((ushort)peers.Length);
			for (int i = 0; i < peers.Length; i++)
			{
				peers[i].Serialize(writer);
			}
		}
	}
}
