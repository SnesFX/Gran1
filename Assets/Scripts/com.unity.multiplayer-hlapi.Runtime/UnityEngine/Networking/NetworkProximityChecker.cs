using System;
using System.Collections.Generic;

namespace UnityEngine.Networking
{
	[AddComponentMenu("Network/NetworkProximityChecker")]
	[RequireComponent(typeof(NetworkIdentity))]
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class NetworkProximityChecker : NetworkBehaviour
	{
		public enum CheckMethod
		{
			Physics3D = 0,
			Physics2D = 1
		}

		[Tooltip("The maximum range that objects will be visible at.")]
		public int visRange = 10;

		[Tooltip("How often (in seconds) that this object should update the set of players that can see it.")]
		public float visUpdateInterval = 1f;

		[Tooltip("Which method to use for checking proximity of players.\n\nPhysics3D uses 3D physics to determine proximity.\n\nPhysics2D uses 2D physics to determine proximity.")]
		public CheckMethod checkMethod;

		[Tooltip("Enable to force this object to be hidden from players.")]
		public bool forceHidden;

		private float m_VisUpdateTime;

		private void Update()
		{
			if (NetworkServer.active && Time.time - m_VisUpdateTime > visUpdateInterval)
			{
				GetComponent<NetworkIdentity>().RebuildObservers(initialize: false);
				m_VisUpdateTime = Time.time;
			}
		}

		public override bool OnCheckObserver(NetworkConnection newObserver)
		{
			if (forceHidden)
			{
				return false;
			}
			GameObject gameObject = null;
			for (int i = 0; i < newObserver.playerControllers.Count; i++)
			{
				PlayerController playerController = newObserver.playerControllers[i];
				if (playerController != null && playerController.gameObject != null)
				{
					gameObject = playerController.gameObject;
					break;
				}
			}
			if (gameObject == null)
			{
				return false;
			}
			return (gameObject.transform.position - base.transform.position).magnitude < (float)visRange;
		}

		public override bool OnRebuildObservers(HashSet<NetworkConnection> observers, bool initial)
		{
			if (forceHidden)
			{
				NetworkIdentity component = GetComponent<NetworkIdentity>();
				if (component.connectionToClient != null)
				{
					observers.Add(component.connectionToClient);
				}
				return true;
			}
			switch (checkMethod)
			{
			case CheckMethod.Physics3D:
			{
				Collider[] array2 = Physics.OverlapSphere(base.transform.position, visRange);
				for (int j = 0; j < array2.Length; j++)
				{
					NetworkIdentity component3 = array2[j].GetComponent<NetworkIdentity>();
					if (component3 != null && component3.connectionToClient != null)
					{
						observers.Add(component3.connectionToClient);
					}
				}
				return true;
			}
			case CheckMethod.Physics2D:
			{
				Collider2D[] array = Physics2D.OverlapCircleAll(base.transform.position, visRange);
				for (int i = 0; i < array.Length; i++)
				{
					NetworkIdentity component2 = array[i].GetComponent<NetworkIdentity>();
					if (component2 != null && component2.connectionToClient != null)
					{
						observers.Add(component2.connectionToClient);
					}
				}
				return true;
			}
			default:
				return false;
			}
		}

		public override void OnSetLocalVisibility(bool vis)
		{
			SetVis(base.gameObject, vis);
		}

		private static void SetVis(GameObject go, bool vis)
		{
			Renderer[] components = go.GetComponents<Renderer>();
			for (int i = 0; i < components.Length; i++)
			{
				components[i].enabled = vis;
			}
			for (int j = 0; j < go.transform.childCount; j++)
			{
				SetVis(go.transform.GetChild(j).gameObject, vis);
			}
		}
	}
}
