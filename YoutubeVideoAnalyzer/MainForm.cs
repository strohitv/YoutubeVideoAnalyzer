using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using YoutubeVideoAnalyser.Logic;
using YoutubeVideoAnalyser.Model;

namespace YoutubeVideoAnalyser
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			afterDtp.Value = new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0);
			beforeDtp.Value = new DateTime(DateTime.Now.Year + 1, 1, 1, 0, 0, 0);
		}

		private void useExternalLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(useExternalLinkTextbox.Text);
		}

		YoutubeAccount account = null;

		private void signInButton_Click(object sender, System.EventArgs e)
		{
			useExternalGroupBox.Enabled = false;
			resultTextbox.Text = string.Empty;

			if (!string.IsNullOrWhiteSpace(useExternalCodeTextbox.Text)
				&& (account != null
				|| (account = AccountConnector.ConnectToAccount(useExternalCodeTextbox.Text, YoutubeApiClientData.ClientId, YoutubeApiClientData.ClientSecret)) != null))
			{
				loggedOutTlp.Visible = false;
				loggedInTlp.Visible = true;
				loggedInLabel.Text = $"Eingeloggt als {account.Title}";

				var snippets = LoadVideos(account, afterDtp.Value, beforeDtp.Value);
				var details = LoadVideoDetails(account, snippets, analysePublicCheckbox.Checked, analyseUnlistedCheckbox.Checked, analysePrivateCheckbox.Checked, analyseVideosCheckbox.Checked, analyseLivestreamsCheckbox.Checked);

				AnalyseDetails(details);
			}
			else if (string.IsNullOrWhiteSpace(useExternalCodeTextbox.Text))
			{
				useExternalCodeTextbox.BackColor = Color.Red;
			}

			useExternalGroupBox.Enabled = true;
		}

		private void AnalyseDetails(VideoItem[] details)
		{
			var videoCount = details.Length;
			var videosCount = details.Where(d => d.liveStreamingDetails == null).Count();
			var streamsCount = videoCount - videosCount;
			var publicCount = details.Count(d => d.status.privacyStatus == "public");
			var unlistedCount = details.Count(d => d.status.privacyStatus == "unlisted");
			var privateCount = videoCount - publicCount - unlistedCount;
			var completeDuration = details.Select(d => d.contentDetails.durationSpan).Aggregate((i, j) => i + j);
			var allViews = details.Select(d => d.statistics.viewCount).Aggregate((i, j) => i + j);
			var allLikes = details.Select(d => d.statistics.likeCount).Aggregate((i, j) => i + j);
			var allDislikes = details.Select(d => d.statistics.dislikeCount).Aggregate((i, j) => i + j);
			var allComments = details.Select(d => d.statistics.commentCount).Aggregate((i, j) => i + j);

			var n = Environment.NewLine;
			resultTextbox.Text = $"Analyse des Zeitraums {afterDtp.Value} bis {beforeDtp.Value}:{n}{n}---{n}{n}"
				+ $"Videos / Streams insgesamt: {videoCount}{n}"
				+ $"Anzahl Videos: {videosCount}{n}"
				+ $"Anzahl Streams: {streamsCount}{n}{n}"
				+ $"Anzahl Öffentlich: {publicCount}{n}"
				+ $"Anzahl Nicht gelistet: {unlistedCount}{n}"
				+ $"Anzahl Privat: {privateCount}{n}{n}"
				+ $"Gesamtdauer aller analysierten Videos / Streams: {completeDuration.Days} Tage, {completeDuration.Hours} Stunden, {completeDuration.Minutes} Minuten und {completeDuration.Seconds} Sekunden{n}{n}"
				+ $"Gesamtzahl der Views: {allViews}{n}"
				+ $"Gesamtzahl der Likes: {allLikes}{n}"
				+ $"Gesamtzahl der Dislikes: {allDislikes}{n}"
				+ $"Gesamtzahl der Kommentare: {allComments}";

			if (exportCsvCheckbox.Checked)
			{
				try
				{
					using (var writer = new StreamWriter(exportCsvTextbox.Text, false))
					{
						var headline = new[] {"ID",
							"Titel",
							"Hochgeladen am",
							"Kategorie-ID",
							"Dauer",
							"Dimension",
							"Auflösung",
							"Hat Untertitel",
							"Ist lizenziert",
							"Eigenes Thumbnail verwendet",
							"Hochladestatus",
							"Sichtbarkeit",
							"Veröffentlicht am",
							"Lizenz",
							"Kann eingebettet werden",
							"Statistiken öffentlich einsehbar",
							"Anzahl Views",
							"Anzahl Likes",
							"Anzahl Dislikes",
							"Anzahl Favoriten",
							"Anzahl Kommentare",
							"Von Youtube zugeordnete Themengebiete",
							"War ein Livestream",
							"Stream begonnen am",
							"Stream beendet am",
							"Stream angekündigt für"
						}
						.Aggregate((i, j) => $"{i},{j}");

						writer.WriteLine(headline);

						var lines = CsvEntry.CreateEntries(details)
							.Select(d => d.Aggregate((i, j) => $"{i},{j}"))
							.Aggregate((i, j) => $"{i}{Environment.NewLine}{j}");

						writer.WriteLine(lines);
					}

					resultTextbox.Text = $"{resultTextbox.Text}{n}{n}---{n}{n}Die Ergebnisse wurden in die Datei \"{exportCsvTextbox.Text}\" geschrieben.";
				}
				catch (Exception ex)
				{ }
			}
		}

		private VideoItem[] LoadVideoDetails(YoutubeAccount account, VideoItem[] snippets, bool analysePublic, bool analyseUnlisted, bool analysePrivate, bool analyseVideos, bool analyseStreams)
		{
			List<VideoItem> items = new List<VideoItem>();

			string pageToken = string.Empty;
			bool fired = false;

			while (snippets.Length > 0 || !fired)
			{
				if (snippets.Length > 0)
				{
					var vids = snippets.Take(50);

					var list = snippets.ToList();
					list.RemoveRange(0, (50 >= list.Count ? list.Count : 50));
					snippets = list.ToArray();

					var ids = vids.Select(v => v.id.videoId).Aggregate((i, j) => i + "%2C" + j);

					var url = $"https://www.googleapis.com/youtube/v3/videos?part=contentDetails%2CfileDetails%2Cid%2CliveStreamingDetails%2Clocalizations%2Cplayer%2CprocessingDetails%2CrecordingDetails%2Csnippet%2Cstatistics%2Cstatus%2Csuggestions%2CtopicDetails&id={ids}&maxResults=50&key={account.Access.ClientSecret}";

					if (!string.IsNullOrWhiteSpace(pageToken))
					{
						url = $"{url}&pageToken={pageToken}";
					}

					HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
					request.Method = "GET";
					request.Credentials = CredentialCache.DefaultCredentials;
					request.ProtocolVersion = HttpVersion.Version11;

					// Header schreiben
					request.Headers.Add($"Authorization: Bearer {account.Access.AccessToken}");

					var answer = WebService.Communicate(request);
					var result = JsonConvert.DeserializeObject<VideoResponse>(answer);

					if (result.items != null)
					{
						items.AddRange(result.items);
					}

					pageToken = result.nextPageToken;
				}

				fired = true;
			}

			var firstFilterList = new List<VideoItem>();

			if (analyseVideos)
			{
				firstFilterList.AddRange(items.Where(i => i.liveStreamingDetails == null));
			}

			if (analyseStreams)
			{
				firstFilterList.AddRange(items.Where(i => i.liveStreamingDetails != null));
			}

			var saveList = new List<VideoItem>();

			if (analysePublic)
			{
				saveList.AddRange(firstFilterList.Where(i => i.status.privacyStatus.ToLower() == "public"));
			}

			if (analyseUnlisted)
			{
				saveList.AddRange(firstFilterList.Where(i => i.status.privacyStatus.ToLower() == "unlisted"));
			}

			if (analysePrivate)
			{
				saveList.AddRange(firstFilterList.Where(i => i.status.privacyStatus.ToLower() == "private"));
			}

			return saveList.ToArray();
		}

		private VideoItem[] LoadVideos(YoutubeAccount account, DateTime after, DateTime before)
		{
			VideoResponse responses = null;

			string pageToken = string.Empty;
			bool fired = false;

			while (!fired || (!string.IsNullOrWhiteSpace(pageToken) && responses.items.Last().snippet.publishedAt >= after))
			{
				var url = $"https://www.googleapis.com/youtube/v3/search?part=snippet&forMine=true&order=date&maxResults=50&type=video&key={account.Access.ClientSecret}";

				if (!string.IsNullOrWhiteSpace(pageToken))
				{
					url = $"{url}&pageToken={pageToken}";
				}

				HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
				request.Method = "GET";
				request.Credentials = CredentialCache.DefaultCredentials;
				request.ProtocolVersion = HttpVersion.Version11;

				// Header schreiben
				request.Headers.Add($"Authorization: Bearer {account.Access.AccessToken}");

				var answer = WebService.Communicate(request);
				var result = JsonConvert.DeserializeObject<VideoResponse>(answer);

				if (responses != null)
				{
					var list = new List<VideoItem>(responses?.items);
					list.AddRange(result.items);
					responses.items = list.ToArray();
				}
				else
				{
					responses = result;
				}

				pageToken = result.nextPageToken;

				fired = true;
			}

			return responses.items.Where(i => i.snippet.publishedAt < before && i.snippet.publishedAt >= after).ToArray();
		}

		private void logoutButton_Click(object sender, EventArgs e)
		{
			account = null;
			useExternalCodeTextbox.Text = string.Empty;

			loggedOutTlp.Visible = true;
			loggedInTlp.Visible = false;
		}

		private void analyseVideosCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			if (!analyseVideosCheckbox.Checked)
			{
				analyseLivestreamsCheckbox.Checked = true;
			}
		}

		private void analyseLivestreamsCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			if (!analyseLivestreamsCheckbox.Checked)
			{
				analyseVideosCheckbox.Checked = true;
			}
		}

		private void analysePublicCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			EnsureOneIsChecked();
		}

		private void analyseUnlistedCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			EnsureOneIsChecked();
		}

		private void analysePrivateCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			EnsureOneIsChecked();
		}

		private void EnsureOneIsChecked()
		{
			if (!analysePublicCheckbox.Checked && !analysePrivateCheckbox.Checked && !analyseUnlistedCheckbox.Checked)
			{
				analysePublicCheckbox.Checked = true;
			}
		}

		private void exportCsvCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			exportCsvTextbox.Enabled = exportCsvButton.Enabled = exportCsvCheckbox.Checked;
		}

		private void exportCsvButton_Click(object sender, EventArgs e)
		{
			var result = exportCsvDialog.ShowDialog(this);

			if (result == DialogResult.OK)
			{
				exportCsvTextbox.Text = exportCsvDialog.FileName;
			}
		}

		private void useExternalCodeTextbox_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(useExternalCodeTextbox.Text))
			{
				useExternalCodeTextbox.BackColor = Color.White;
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			useExternalLinkTextbox.Text = $"https://accounts.google.com/o/oauth2/auth?client_id={YoutubeApiClientData.ClientId}&redirect_uri=urn:ietf:wg:oauth:2.0:oob&scope=https://www.googleapis.com/auth/youtube+https://www.googleapis.com/auth/youtube.force-ssl+https://www.googleapis.com/auth/youtube.readonly+https://www.googleapis.com/auth/youtubepartner&response_type=code&approval_prompt=force&access_type=offline";
		}
	}
}
