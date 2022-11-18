using UnityEngine;

namespace FirebaseForSchema.Config
{
	[CreateAssetMenu(fileName = "FirebaseConfig", menuName = "FirebaseForSchema/Config", order = 0)]
	public class FirebaseConfig : ScriptableObject
	{
		public string apiKey;

		public string prodUrl;
		public string devUrl;
		public bool isDebug = true;

		public string authUrl;
		public string examId;
	}
}
