using System;

namespace UnityEngine.Networking
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class PlayerController
	{
		internal const short kMaxLocalPlayers = 8;

		public short playerControllerId = -1;

		public NetworkIdentity unetView;

		public GameObject gameObject;

		public const int MaxPlayersPerClient = 32;

		public bool IsValid => playerControllerId != -1;

		public PlayerController()
		{
		}

		internal PlayerController(GameObject go, short playerControllerId)
		{
			gameObject = go;
			unetView = go.GetComponent<NetworkIdentity>();
			this.playerControllerId = playerControllerId;
		}

		public override string ToString()
		{
			return string.Format("ID={0} NetworkIdentity NetID={1} Player={2}", new object[3]
			{
				playerControllerId,
				(unetView != null) ? unetView.netId.ToString() : "null",
				(gameObject != null) ? gameObject.name : "null"
			});
		}
	}
}
