using System;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using YoutubeVideoAnalyser.Model;

namespace YoutubeVideoAnalyser.Logic
{
	internal static class AccountConnector
	{
		public static YoutubeAccount ConnectToAccount(string code, string clientId, string clientSecret, string uri = "urn:ietf:wg:oauth:2.0:oob")
		{
			string content = $"code={code}&client_id={clientId}&client_secret={clientSecret}&redirect_uri={uri}&grant_type=authorization_code";
			var bytes = Encoding.UTF8.GetBytes(content);

			// Request erstellen
			WebRequest request = WebRequest.Create("https://www.googleapis.com/oauth2/v4/token");
			request.Method = "POST";
			request.ContentType = "application/x-www-form-urlencoded";

			string result = WebService.Communicate(request, bytes);

			YoutubeAccount account = null;
			var authResponse = JsonConvert.DeserializeObject<YoutubeAuthResponse>(result);

			var access = new YoutubeAccountAccess();
			access.ClientId = clientId;
			access.ClientSecret = clientSecret;

			if (authResponse != null && !string.IsNullOrWhiteSpace(authResponse.access_token))
			{
				access.AccessToken = authResponse.access_token;
				access.RefreshToken = authResponse.refresh_token;
				access.TokenType = authResponse.token_type;
				access.ExpirationDate = DateTime.Now.AddSeconds(authResponse.expires_in);

				var accountDetails = GetAccountDetails(access);
				var acc = accountDetails.items.First();
				account = YoutubeAccount.Create(acc.id, acc.snippet.country, acc.snippet.title);

				account.Access = access;
			}

			return account;
		}

		private static Response GetAccountDetails(YoutubeAccountAccess access)
		{
			string url = $"https://www.googleapis.com/youtube/v3/channels?part=snippet&mine=true&key={access.ClientSecret}";
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
			request.Method = "GET";
			request.Credentials = CredentialCache.DefaultCredentials;
			request.ProtocolVersion = HttpVersion.Version11;

			// Header schreiben
			request.Headers.Add($"Authorization: Bearer {access.AccessToken}");

			var answer = WebService.Communicate(request);
			Response response = JsonConvert.DeserializeObject<Response>(answer);

			return response;
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
