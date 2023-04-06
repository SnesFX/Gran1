using System;

namespace UnityEngine.Networking
{
	[Serializable]
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public struct NetworkSceneId : IEquatable<NetworkSceneId>
	{
		[SerializeField]
		private uint m_Value;

		public uint Value => m_Value;

		public NetworkSceneId(uint value)
		{
			m_Value = value;
		}

		public bool IsEmpty()
		{
			return m_Value == 0;
		}

		public override int GetHashCode()
		{
			return (int)m_Value;
		}

		public override bool Equals(object obj)
		{
			if (obj is NetworkSceneId)
			{
				return Equals((NetworkSceneId)obj);
			}
			return false;
		}

		public bool Equals(NetworkSceneId other)
		{
			return this == other;
		}

		public static bool operator ==(NetworkSceneId c1, NetworkSceneId c2)
		{
			return c1.m_Value == c2.m_Value;
		}

		public static bool operator !=(NetworkSceneId c1, NetworkSceneId c2)
		{
			return c1.m_Value != c2.m_Value;
		}

		public override string ToString()
		{
			return m_Value.ToString();
		}
	}
}
