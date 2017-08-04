using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;

namespace Scrobble_Follower
{
  public static class ImageRepository
  {
    private static readonly Dictionary<string, Image> _images = new Dictionary<string, Image>(); 
    public static void ImageForUrl(string url, Action<Image> callback)
    {
      if (_images.ContainsKey(url))
      {
        callback(_images[url]);
        return;
      }

      using (var client = new WebClient())
      {
        client.DownloadDataCompleted += (s, e) => SetImage(e.Result, url, callback);
        client.DownloadDataAsync(new Uri(url));
      }
    }

    private static void SetImage(byte[] data, string url, Action<Image> callback)
    {
      var image = ImageFromStream(data);
      if (!_images.ContainsKey(url)) _images.Add(url, image);
      callback(image);
    }

    private static Image ImageFromStream(byte[] data)
    {
      using (var ms = new MemoryStream(data))
      {
        return Image.FromStream(ms);
      }
    }
  }
}
