using System;
using System.Collections.Generic;
using FirebaseForSchema.RestClient.Models;
using FirebaseForSchema.RestClient.Packages.RestClient.Helpers;
using client = FirebaseForSchema.RestClient.Packages.RestClient.RestClient;
using FirebaseForSchema.Config;
using UnityEngine;

namespace FirebaseForSchema
{
	public class FirebaseManager : MonoBehaviour
	{
		public FirebaseConfig firebaseConfig;

		private RequestHelper _currentRequest;
		private string _useUrl;

		public static FirebaseManager instance;

		private void Awake()
		{
			if (instance == null)
			{
				instance = this;
				DontDestroyOnLoad(gameObject);
			}
			else
			{
				Destroy(gameObject);
			}

			_useUrl = firebaseConfig.isDebug ? firebaseConfig.devUrl : firebaseConfig.prodUrl;
		}

		public void Login(string em, string pass, Action<AuthResponse> onSuccess, Action<Exception> onFailed)
		{
			_currentRequest = new RequestHelper{
				Uri = firebaseConfig.authUrl,
				Params = new Dictionary<string, string>{
					{"key", firebaseConfig.apiKey}
				},
				Body = new AuthRequest{
					email = em,
					password = pass,
					returnSecureToken = true
				},
				EnableDebug = firebaseConfig.isDebug,
			};

			client.Post<AuthResponse>(_currentRequest).Then(onSuccess).Catch(onFailed);
		}

		public void UploadResult(string userId, Result data, string examId, string idToken, Action<Result> onSuccess, Action<Exception> onFailed)
		{
			_currentRequest = new RequestHelper(){
				Uri = _useUrl + "results/" + examId + "/" + userId + ".json",
				Params = new Dictionary<string, string>{
					{"auth", idToken}
				},
				Body = data,
				EnableDebug = firebaseConfig.isDebug,
			};

			client.Put<Result>(_currentRequest).Then(onSuccess).Catch(onFailed);
		}

		public void AddUserToExam(string userId, double timestamp, string examId, string idToken, Action<Exception> onFailed)
		{
			_currentRequest = new RequestHelper(){
				Uri = _useUrl + "exams/" + examId + "/users.json",
				Params = new Dictionary<string, string>{
					{"auth", idToken}
				},
				BodyString = $"{{\"{userId}\":{timestamp}}}",
				EnableDebug = firebaseConfig.isDebug,
			};

			client.Patch(_currentRequest).Catch(onFailed);
		}
	}
}
