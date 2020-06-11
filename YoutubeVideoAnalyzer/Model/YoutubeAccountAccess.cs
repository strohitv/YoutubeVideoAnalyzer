using System;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using YoutubeVideoAnalyser.Logic;

namespace YoutubeVideoAnalyser.Model
{
	public class YoutubeAccountAccess
	{
		private string accessToken = string.Empty;
		public string AccessToken
		{
			get
			{
				if (IsExpired)
				{
					accessToken = RefreshAccess();
				}

				return accessToken;
			}
			set
			{
				accessToken = value;
			}
		}

		public DateTime ExpirationDate { get; set; }

		public bool IsExpired => ExpirationDate - new TimeSpan(0, 1, 0) < DateTime.Now;

		public string RefreshToken { get; set; }

		public string TokenType { get; set; }

		public string ClientId { get; set; }

		public string ClientSecret { get; set; }

		internal string RefreshAccess()
		{
			var token = string.Empty;

			// Content zusammenbauen
			string content = $"client_id={ClientId}&client_secret={ClientSecret}&refresh_token={RefreshToken}&grant_type=refresh_token";
			var bytes = Encoding.UTF8.GetBytes(content);

			// Request erstellen
			WebRequest request = WebRequest.Create("https://www.googleapis.com/oauth2/v4/token");
			request.Method = "POST";
			request.ContentType = "application/x-www-form-urlencoded";

			var response = WebService.Communicate(request, bytes);

			if (response != null && !response.Contains("revoked"))
			{
				// Account 
				var authResponse = JsonConvert.DeserializeObject<YoutubeAuthResponse>(response);

				if (!string.IsNullOrWhiteSpace(authResponse.access_token))
				{
					token = authResponse.access_token;
				}
			}

			return token;
		}

		private class YoutubeAuthResponse
		{
			public string access_token { get; set; }
			public string token_type { get; set; }
			public int expires_in { get; set; }
			public string refresh_token { get; set; }
		}
	}
}
