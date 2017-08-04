using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Windows.Forms;

namespace Scrobble_Follower
{
  public partial class FollowForm : Form
  {
    public FollowForm()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      userTextBox.Text = Config.DefaultUser;
      var timer = new Timer { Interval = 5000};
      timer.Tick += Tick;
      timer.Start();
      Tick(null, null);
    }

    private void Tick(object sender, EventArgs e)
    {
      try
      {
        var json = new WebClient().DownloadString(
        $@"https://ws.audioscrobbler.com/2.0/?method=user.getrecenttracks&user={User}&api_key={Config.ApiKey}&format=json&limit=5");
        dynamic obj = JObject.Parse(json);
        LoadTrack(obj.recenttracks.track[0], track1);
        LoadTrack(obj.recenttracks.track[1], track2);
        LoadTrack(obj.recenttracks.track[2], track3);
        LoadTrack(obj.recenttracks.track[3], track4);
      }
      catch
      {
        
      }
    }

    private void LoadTrack(dynamic track, Track trackControl)
    {
      var artist = track.artist["#text"].ToString();
      var trackName = track.name.ToString();
      var album = track.album["#text"].ToString();
      var imageUrl = track.image[2]["#text"].ToString();
      trackControl.LoadTrack(new TrackInfo(trackName, artist, album)
        .PlayedTime(track)
        .LoadImage(imageUrl));
    }

    private string User => userTextBox.Text;

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox1_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        e.SuppressKeyPress = true;
        Tick(sender, e);
      }
    }
  }
}
