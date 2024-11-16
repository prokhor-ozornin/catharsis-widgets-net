using Catharsis.Extensions;
using Convert = System.Convert;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IInlineImageWidget"/>
public class InlineImageWidget : WebWidget, IInlineImageWidget
{
  private byte[] contents;
  private string format;

  /// <inheritdoc cref="IInlineImageWidget.Contents(byte[])"/>
  public IInlineImageWidget Contents(byte[] contents)
  {
    this.contents = contents ?? throw new ArgumentNullException(nameof(contents));
    return this;
  }

  /// <inheritdoc cref="IInlineImageWidget.Contents()"/>
  public byte[] Contents() => contents;

  /// <inheritdoc cref="IInlineImageWidget.Format(string)"/>
  public IInlineImageWidget Format(string format)
  {
    if (format is null) throw new ArgumentNullException(nameof(format));
    if (format.IsEmpty()) throw new ArgumentException(nameof(format));

    this.format = format;
    return this;
  }

  /// <inheritdoc cref="IInlineImageWidget.Format()"/>
  public string Format() => format;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (contents is null)
    {
      return string.Empty;
    }

    return new TagBuilder("img")
      .Attribute("src", string.Format("data:{1};base64,{0}", Convert.ToBase64String(Contents()), Format().IsEmpty() ? "image" : Format()))
      .ToString();
  }
}