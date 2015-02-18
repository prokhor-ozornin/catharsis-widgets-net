using System;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class MediaSource : IMediaSource, IEquatable<MediaSource>
  {
    private string contentType;
    private string url;

    public MediaSource(string url, string contentType)
    {
      this.Url = url;
      this.ContentType = contentType;
    }

    public string ContentType
    {
      get { return this.contentType; }
      set
      {
        Assertion.NotEmpty(value);

        this.contentType = value;
      }
    }

    public string Url
    {
      get { return this.url; }
      set
      {
        Assertion.NotEmpty(value);

        this.url = value;
      }
    }
    
    public bool Equals(MediaSource other)
    {
      return this.Equality(other, source => source.Url);
    }

    public override bool Equals(object other)
    {
      return this.Equals(other as MediaSource);
    }

    public override int GetHashCode()
    {
      return this.GetHashCode(source => source.Url);
    }

    public string ToHtmlString()
    {
      return this.ToString();
    }

    public override string ToString()
    {
      return new TagBuilder("source").Attribute("src", this.Url).Attribute("type", this.ContentType).ToString();
    }
  }
}