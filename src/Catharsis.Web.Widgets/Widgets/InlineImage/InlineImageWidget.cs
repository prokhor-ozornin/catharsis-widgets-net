using Catharsis.Extensions;
using Convert = System.Convert;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IInlineImageWidget"/>
public class InlineImageWidget : WebWidget, IInlineImageWidget
{
  private byte[] ContentsProperty { get; set; }
  private string FormatProperty { get; set; }

  /// <inheritdoc cref="IInlineImageWidget.Contents(byte[])"/>
  public IInlineImageWidget Contents(byte[] contents)
  {
    ContentsProperty = contents ?? throw new ArgumentNullException(nameof(contents));
    return this;
  }

  /// <inheritdoc cref="IInlineImageWidget.Contents()"/>
  public byte[] Contents() => ContentsProperty;

  /// <inheritdoc cref="IInlineImageWidget.Format(string)"/>
  public IInlineImageWidget Format(string format)
  {
    if (format is null) throw new ArgumentNullException(nameof(format));
    if (format.IsEmpty()) throw new ArgumentException(nameof(format));

    FormatProperty = format;
    return this;
  }

  /// <inheritdoc cref="IInlineImageWidget.Format()"/>
  public string Format() => FormatProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => ContentsProperty is null ? string.Empty : 
    new TagBuilder("img")
      .Attribute("src", string.Format("data:{1};base64,{0}", Convert.ToBase64String(Contents()), Format().IsEmpty() ? "image" : Format()))
      .ToString();
}