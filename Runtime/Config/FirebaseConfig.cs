using UnityEngine;

namespace FirebaseForSchema.Config
{
	[CreateAssetMenu(fileName = "FirebaseConfig", menuName = "FirebaseForSchema/Config", order = 0)]
	public class FirebaseConfig : ScriptableObject
	{
		public string apiKey = "AIzaSyBy_1sM0l0FLaUD9pgrXyttkn_F-j9mv1A";

		public string prodUrl = "https://juanola-5f521.firebaseio.com/";
		public string devUrl = "https://juanola-5f522.firebaseio.com/";
		public bool isDebug = true;

		public string authUrl = "https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword";
		public string examId = "offShore";
	}
}
