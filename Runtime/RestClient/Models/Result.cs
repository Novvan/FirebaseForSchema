using System;

namespace FirebaseForSchema.RestClient.Models
{
	[Serializable]
	public class Result
	{
		public Answer[] answers;
		public double date;
		public int grade;
		public string photoUrl;
		public int simulationSecs;
		public string userDisplayName;
		
		public override string ToString()
		{
			return UnityEngine.JsonUtility.ToJson(this, true);
		}
	}
}
