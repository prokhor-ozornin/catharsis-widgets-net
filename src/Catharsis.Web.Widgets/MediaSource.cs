using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IMediaSource"/>
public class MediaSource : IMediaSource, IEquatable<IMediaSource>
{
  protected string contentType;
  protected string url;

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="url"></param>
  /// <param name="contentType"></param>
  public MediaSource(string url, string contentType)
  {
    Url = url;
    ContentType = contentType;
  }

  /// <inheritdoc cref="IMediaSource.ContentType"/>
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

  /// <inheritdoc cref="IMediaSource.Url"/>
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

  /// <inheritdoc cref="IEquatable{IMediaSource}.Equals(IMediaSource?)"/>
  public bool Equals(IMediaSource other) => this.Equality(other, source => source.Url);

  /// <inheritdoc cref="object.Equals(object?)"/>
  public override bool Equals(object other) => Equals(other as IMediaSource);

  /// <inheritdoc cref="object.GetHashCode()"/>
  public override int GetHashCode() => this.HashCode(source => source.Url);

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public string ToHtml() => ToString();

  /// <inheritdoc cref="object.ToString()"/>
  public override string ToString() => new TagBuilder("source")
    .Attribute("src", Url)
    .Attribute("type", ContentType)
    .ToString();
}