using System;

namespace FirebaseForSchema.RestClient.Models
{
	[Serializable]
	public class AuthResponse
	{
		public string localId;
		public string email;
		public string displayName;
		public string idToken;
		public bool registered;
		public string refreshToken;
		public long expiresIn;

		public override string ToString()
		{
			return UnityEngine.JsonUtility.ToJson(this, true);
		}
	}
}
