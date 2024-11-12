using System.Web.Mvc;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

public class MediaSource : IMediaSource, IEquatable<MediaSource>
{
  private string contentType;
  private string url;

  public MediaSource(string url, string contentType)
  {
    Url = url;
    ContentType = contentType;
  }

  public string ContentType
  {
    get => contentType;
    set
    {
      if (value is null) throw new ArgumentNullException(nameof(value));
      if (value.IsEmpty()) throw new ArgumentException(nameof(value));

      contentType = value;
    }
  }

  public string Url
  {
    get => url;
    set
    {
      if (value is null) throw new ArgumentNullException(nameof(value));
      if (value.IsEmpty()) throw new ArgumentException(nameof(value));

      url = value;
    }
  }
    
  public bool Equals(MediaSource other) => this.Equality(other, source => source.Url);

  public override bool Equals(object other) => Equals(other as MediaSource);

  public override int GetHashCode() => this.GetHashCode(source => source.Url);

  public string ToHtmlString() => ToString();

  public override string ToString() => new TagBuilder("source").Attribute("src", this.Url).Attribute("type", this.ContentType).ToString();
}