using System;

namespace YoutubeVideoAnalyser.Model
{
	public class YoutubeAccount
	{
		public string Id { get; } = string.Empty;

		public string Region { get; } = string.Empty;

		public string Title { get; } = string.Empty;
		
		public Uri Uri { get; } = null;

		public YoutubeAccountAccess Access { get; set; }

		internal YoutubeAccount(string id, string region, string title, Uri uri)
		{
			Id = id;
			Region = region;
			Title = title;
			Uri = uri;
		}

		public YoutubeAccount(string id, string region, string title, YoutubeAccountAccess access)
		{
			Id = id;
			Region = region;
			Title = title;
			Uri = new Uri($"https://youtube.com/channel/{id}");

			Access = access;
		}

		public static YoutubeAccount Create(string id, string region, string title)
		{
			return new YoutubeAccount(id, region, title, new Uri($"https://youtube.com/channel/{id}"));
		}
	}
}
