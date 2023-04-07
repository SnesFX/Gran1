using System;
using UnityEngine.Networking.NetworkSystem;
using UnityEngine.SceneManagement;

namespace UnityEngine.Networking
{
	[DisallowMultipleComponent]
	[AddComponentMenu("Network/NetworkLobbyPlayer")]
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class NetworkLobbyPlayer : NetworkBehaviour
	{
		[Tooltip("Enable to show the default lobby GUI for this player.")]
		[SerializeField]
		public bool ShowLobbyGUI = true;

		private byte m_Slot;

		private bool m_ReadyToBegin;

		public byte slot
		{
			get
			{
				return m_Slot;
			}
			set
			{
				m_Slot = value;
			}
		}

		public bool readyToBegin
		{
			get
			{
				return m_ReadyToBegin;
			}
			set
			{
				m_ReadyToBegin = value;
			}
		}

		private void Start()
		{
			Object.DontDestroyOnLoad(base.gameObject);
		}

		private void OnEnable()
		{
			SceneManager.sceneLoaded += OnSceneLoaded;
		}

		private void OnDisable()
		{
			SceneManager.sceneLoaded -= OnSceneLoaded;
		}

		public override void OnStartClient()
		{
			NetworkLobbyManager lobbyManager = GetLobbyManager();
			if ((bool)lobbyManager)
			{
				lobbyManager.lobbySlots[m_Slot] = this;
				m_ReadyToBegin = false;
				OnClientEnterLobby();
			}
			else
			{
				Debug.LogError("LobbyPlayer could not find a NetworkLobbyManager. The LobbyPlayer requires a NetworkLobbyManager object to function. Make sure that there is one in the scene.");
			}
		}

		public void SendReadyToBeginMessage()
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("NetworkLobbyPlayer SendReadyToBeginMessage");
			}
			NetworkLobbyManager lobbyManager = GetLobbyManager();
			if ((bool)lobbyManager)
			{
				LobbyReadyToBeginMessage lobbyReadyToBeginMessage = new LobbyReadyToBeginMessage();
				lobbyReadyToBeginMessage.slotId = (byte)base.playerControllerId;
				lobbyReadyToBeginMessage.readyState = true;
				lobbyManager.client.Send(43, lobbyReadyToBeginMessage);
			}
		}

		public void SendNotReadyToBeginMessage()
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("NetworkLobbyPlayer SendReadyToBeginMessage");
			}
			NetworkLobbyManager lobbyManager = GetLobbyManager();
			if ((bool)lobbyManager)
			{
				LobbyReadyToBeginMessage lobbyReadyToBeginMessage = new LobbyReadyToBeginMessage();
				lobbyReadyToBeginMessage.slotId = (byte)base.playerControllerId;
				lobbyReadyToBeginMessage.readyState = false;
				lobbyManager.client.Send(43, lobbyReadyToBeginMessage);
			}
		}

		public void SendSceneLoadedMessage()
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("NetworkLobbyPlayer SendSceneLoadedMessage");
			}
			NetworkLobbyManager lobbyManager = GetLobbyManager();
			if ((bool)lobbyManager)
			{
				IntegerMessage msg = new IntegerMessage(base.playerControllerId);
				lobbyManager.client.Send(44, msg);
			}
		}

		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
			NetworkLobbyManager lobbyManager = GetLobbyManager();
			if ((!lobbyManager || !(scene.name == lobbyManager.lobbyScene)) && base.isLocalPlayer)
			{
				SendSceneLoadedMessage();
			}
		}

		private NetworkLobbyManager GetLobbyManager()
		{
			return NetworkManager.singleton as NetworkLobbyManager;
		}

		public void RemovePlayer()
		{
			if (base.isLocalPlayer && !m_ReadyToBegin)
			{
				if (LogFilter.logDebug)
				{
					Debug.Log("NetworkLobbyPlayer RemovePlayer");
				}
				ClientScene.RemovePlayer(GetComponent<NetworkIdentity>().playerControllerId);
			}
		}

		public virtual void OnClientEnterLobby()
		{
		}

		public virtual void OnClientExitLobby()
		{
		}

		public virtual void OnClientReady(bool readyState)
		{
		}

		public override bool OnSerialize(NetworkWriter writer, bool initialState)
		{
			writer.WritePackedUInt32(1u);
			writer.Write(m_Slot);
			writer.Write(m_ReadyToBegin);
			return true;
		}

		public override void OnDeserialize(NetworkReader reader, bool initialState)
		{
			if (reader.ReadPackedUInt32() != 0)
			{
				m_Slot = reader.ReadByte();
				m_ReadyToBegin = reader.ReadBoolean();
			}
		}

		private void OnGUI()
		{
			if (!ShowLobbyGUI)
			{
				return;
			}
			NetworkLobbyManager lobbyManager = GetLobbyManager();
			if ((bool)lobbyManager && (!lobbyManager.showLobbyGUI || SceneManager.GetSceneAt(0).name != lobbyManager.lobbyScene))
			{
				return;
			}
			Rect position = new Rect(100 + m_Slot * 100, 200f, 90f, 20f);
			if (base.isLocalPlayer)
			{
				GUI.Label(text: (!m_ReadyToBegin) ? "(Not Ready)" : "(Ready)", position: position);
				if (m_ReadyToBegin)
				{
					position.y += 25f;
					if (GUI.Button(position, "STOP"))
					{
						SendNotReadyToBeginMessage();
					}
					return;
				}
				position.y += 25f;
				if (GUI.Button(position, "START"))
				{
					SendReadyToBeginMessage();
				}
				position.y += 25f;
				if (GUI.Button(position, "Remove"))
				{
					ClientScene.RemovePlayer(GetComponent<NetworkIdentity>().playerControllerId);
				}
			}
			else
			{
				GUI.Label(position, string.Concat("Player [", base.netId, "]"));
				position.y += 25f;
				GUI.Label(position, "Ready [" + m_ReadyToBegin + "]");
			}
		}
	}
}
