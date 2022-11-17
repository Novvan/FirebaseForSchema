using System;

namespace FirebaseForSchema.RestClient.Models
{
	[Serializable]
	public class AuthRequest
	{
		public string email;
		public string password;
		public bool returnSecureToken;

		public override string ToString()
		{
			return UnityEngine.JsonUtility.ToJson(this, true);
		}
	}
}
