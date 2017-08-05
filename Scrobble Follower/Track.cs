using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Scrobble_Follower
{
  public partial class Track : UserControl
  {
    private string _lastUrl;
    public Track()
    {
      InitializeComponent();

    }

    public void LoadTrack(TrackInfo trackInfo)
    {
      trackLabel.Text = trackInfo.Track;
      artistLabel.Text = trackInfo.Artist;
      albumLabel.Text = trackInfo.Album;
      timeLabel.Text = TimeString(trackInfo.Time);

      if (_lastUrl == trackInfo.ImageUrl) return;
      _lastUrl = trackInfo.ImageUrl;
      new Thread(() => SetImageWhenImage(trackInfo)).Start();
    }

    private string TimeString(DateTime? time)
    {
      if (!time.HasValue) return "Now Playing";
      var span = (DateTime.Now - time.Value);
      if (span.TotalSeconds < 60) return $"{span.Seconds} second{(span.Seconds == 1 ? "" : "s")} ago";
      if (span.TotalMinutes < 60) return $"{span.Minutes} minute{(span.Minutes == 1 ? "" : "s")} ago";
      if (span.TotalHours < 24) return $"{span.Hours} hour{(span.Hours == 1 ? "" : "s")} ago";
      return $"{span.Days} day{(span.Days == 1 ? "" : "s")} ago";
    }


    private void SetImageWhenImage(TrackInfo trackInfo)
    {
      SpinWait.SpinUntil(() => trackInfo.Image != null, 50000);

      pictureBox.BackgroundImage = new Bitmap(trackInfo.Image);
    }
  }
}
