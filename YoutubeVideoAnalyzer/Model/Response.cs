using System;
using System.Xml;
using Newtonsoft.Json;

namespace YoutubeVideoAnalyser.Model
{
	public class Response
	{
		public string kind { get; set; }
		public string etag { get; set; }
		public string prevPageToken { get; set; }
		public string nextPageToken { get; set; }
		public PageInfo pageInfo { get; set; }
		public Item[] items { get; set; }
	}
	public class VideoResponse
	{
		public string kind { get; set; }
		public string etag { get; set; }
		public string prevPageToken { get; set; }
		public string nextPageToken { get; set; }
		public PageInfo pageInfo { get; set; }
		public VideoItem[] items { get; set; }
	}

	public class PageInfo
	{
		public int totalResults { get; set; }
		public int resultsPerPage { get; set; }
	}

	public class Item
	{
		public string kind { get; set; }
		public string etag { get; set; }
		public string id { get; set; }
		public ContentDetails contentDetails { get; set; }
		public Snippet snippet { get; set; }
	}

	public class VideoItem
	{
		public string kind { get; set; }
		public string etag { get; set; }
		public dynamic id { get; set; }
		public string[] topicCategories { get; set; }
		public ContentDetails contentDetails { get; set; }
		public Snippet snippet { get; set; }
		public Status status { get; set; }
		public Statistics statistics { get; set; }
		public FileDetails fileDetails { get; set; }
		public ProcessingDetails processingDetails { get; set; }
		public LiveStreamingDetails liveStreamingDetails { get; set; }
	}

	public class FileDetails
	{
		public string fileName { get; set; }
	}

	public class LiveStreamingDetails
	{
		public DateTime actualStartTime { get; set; }
		public DateTime actualEndTime { get; set; }
		public DateTime scheduledStartTime { get; set; }
	}


	public class ProcessingDetails
	{
		public string processingStatus { get; set; }
	}

	public class Status
	{
		public string uploadStatus { get; set; }
		public string privacyStatus { get; set; }
		public string license { get; set; }
		public DateTime publishAt { get; set; }
		public bool embeddable { get; set; }
		public bool publicStatsViewable { get; set; }
	}

	public class Statistics
	{
		public long viewCount { get; set; }
		public long likeCount { get; set; }
		public long dislikeCount { get; set; }
		public long favoriteCount { get; set; }
		public long commentCount { get; set; }
	}

	public class Id
	{
		public string kind { get; set; }
		public string videoId { get; set; }
	}

	public class ContentDetails
	{
		public string videoId { get; set; }
		public DateTime videoPublishedAt { get; set; }
		public string duration { get; set; }
		[JsonIgnore]
		public TimeSpan durationSpan => XmlConvert.ToTimeSpan(duration);
		public string dimension { get; set; }
		public string definition { get; set; }
		public bool caption { get; set; }
		public bool licensedContent { get; set; }
		public string projection { get; set; }
		public bool hasCustomThumbnail { get; set; }
	}

	public class Snippet
	{
		public string title { get; set; }
		public string description { get; set; }
		public string customUrl { get; set; }
		public DateTime publishedAt { get; set; }
		public string country { get; set; }
		public Thumbnails thumbnails { get; set; }
		public Localization localized { get; set; }
		public string channelId { get; set; }
		public bool assignable { get; set; }
		public int categoryId { get; set; }
		public string hl { get; set; }
		public string name { get; set; }
	}

	public class Thumbnails
	{
		public Url Default { get; set; }
		public Url medium { get; set; }
		public Url high { get; set; }
	}

	public class Url
	{
		public string url { get; set; }
	}

	public class Localization
	{
		public string title { get; set; }
		public string description { get; set; }
	}
}
