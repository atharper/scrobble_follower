using System;
using System.Drawing;

namespace Scrobble_Follower
{
  public class TrackInfo
  {
    public TrackInfo() {}

    public TrackInfo(string track, string artist, string album) : this()
    {
      Track = track;
      Artist = artist;
      Album = album;
    }

    public string Track { get; }
    public string Artist { get; }
    public string Album { get; }
    public string ImageUrl { get; private set; }
    public DateTime? Time { get; private set; } 
    public Image Image { get; private set; }

    public TrackInfo LoadImage(string url)
    {
      ImageUrl = url;
      ImageRepository.ImageForUrl(url, image => Image = image);
      return this;
    }

    public TrackInfo PlayedTime(dynamic track)
    {
      if (track["@attr"] != null && track["@attr"].nowplaying != null && track["@attr"].nowplaying == "true") return this;
      if (track.date == null || track.date.uts == null) return this;

      var epoc = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
      Time = epoc.AddSeconds(double.Parse(track.date.uts.ToString())).ToLocalTime();

      return this;
    }
  }
}
