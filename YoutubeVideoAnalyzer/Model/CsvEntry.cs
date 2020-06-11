using System.Linq;

namespace YoutubeVideoAnalyser.Model
{
	public class CsvEntry
	{
		public static string[][] CreateEntries(VideoItem[] details)
		{
			var entries = details.Select(d => new string[] { d.id.ToString(),
				$"\"{d.snippet.title.Replace("\"", "\"\"")}\"",
				d.snippet.publishedAt.ToString(),
				d.snippet.categoryId.ToString(),
				d.contentDetails.durationSpan.ToString(),
				d.contentDetails.dimension,
				d.contentDetails.definition,
				d.contentDetails.caption ? "1" :  "0",
				d.contentDetails.licensedContent ?"1" :  "0",
				d.contentDetails.hasCustomThumbnail ? "1" :  "0",
				d.status.uploadStatus,
				d.status.privacyStatus,
				d.status.publishAt.ToString(),
				d.status.license,
				d.status.embeddable ? "1" : "0",
				d.status.publicStatsViewable ? "1" : "0",
				d.statistics.viewCount.ToString(),
				d.statistics.likeCount.ToString(),
				d.statistics.dislikeCount.ToString(),
				d.statistics.favoriteCount.ToString(),
				d.statistics.commentCount.ToString(),
				d.topicCategories?.Aggregate((i, j) => $"{i} + {j}"),
				d.liveStreamingDetails != null ? "1" : "0",
				d.liveStreamingDetails?.actualStartTime.ToString(),
				d.liveStreamingDetails?.actualEndTime.ToString(),
				d.liveStreamingDetails?.scheduledStartTime.ToString()
			}).ToArray();

			return entries;
		}
	}
}




// id

// snippet: {
// title
// publishedAt
// categoryId
// }

// contendDetails: {
// duration
// dimension 
// definition
// caption
// licensedContend
// hasCustomThumbnail
// }

// status {
// uploadStatus
// privacyStatus
// publishAt
// license
// embeddable
// publicStatsViewable
// }

// statistics {
// viewCount
// likeCount
// dislikeCount
// favoriteCount
// commentCount
// }

// topicCategories

// liveStreamingDetails {
// actualStartTime
// actualEndTime
// scheduledStartTime
// }