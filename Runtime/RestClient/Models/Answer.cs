using System;

namespace FirebaseForSchema.RestClient.Models
{
	[Serializable]
	public class Answer
	{
		public string description;
		public int logTime;
		public string type;
		
		public override string ToString()
		{
			return UnityEngine.JsonUtility.ToJson(this, true);
		}
	}
}
