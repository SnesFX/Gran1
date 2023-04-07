using System;

namespace UnityEngine.Networking
{
	[Serializable]
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public struct NetworkInstanceId : IEquatable<NetworkInstanceId>
	{
		[SerializeField]
		private readonly uint m_Value;

		public static NetworkInstanceId Invalid = new NetworkInstanceId(uint.MaxValue);

		internal static NetworkInstanceId Zero = new NetworkInstanceId(0u);

		public uint Value => m_Value;

		public NetworkInstanceId(uint value)
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
			if (obj is NetworkInstanceId)
			{
				return Equals((NetworkInstanceId)obj);
			}
			return false;
		}

		public bool Equals(NetworkInstanceId other)
		{
			return this == other;
		}

		public static bool operator ==(NetworkInstanceId c1, NetworkInstanceId c2)
		{
			return c1.m_Value == c2.m_Value;
		}

		public static bool operator !=(NetworkInstanceId c1, NetworkInstanceId c2)
		{
			return c1.m_Value != c2.m_Value;
		}

		public override string ToString()
		{
			return m_Value.ToString();
		}
	}
}
