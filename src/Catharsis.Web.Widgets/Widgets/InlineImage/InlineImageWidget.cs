using Catharsis.Extensions;
using Convert = System.Convert;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IInlineImageWidget"/>
public class InlineImageWidget : WebWidget, IInlineImageWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte[] ContentsProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string FormatProperty { get; set; }

  /// <inheritdoc cref="IInlineImageWidget.Contents(byte[])"/>
  public virtual IInlineImageWidget Contents(byte[] contents)
  {
    ContentsProperty = contents ?? throw new ArgumentNullException(nameof(contents));
    return this;
  }

  /// <inheritdoc cref="IInlineImageWidget.Format(string)"/>
  public virtual IInlineImageWidget Format(string format)
  {
    if (format is null) throw new ArgumentNullException(nameof(format));
    if (format.IsEmpty()) throw new ArgumentException(nameof(format));

    FormatProperty = format;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new InlineImageWidget
  {
    ContentsProperty = ContentsProperty,
    FormatProperty = FormatProperty
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => ContentsProperty is null ? string.Empty : 
    new TagBuilder("img")
      .Attribute("src", string.Format("data:{1};base64,{0}", Convert.ToBase64String(ContentsProperty), FormatProperty.IsUnset() ? "image" : FormatProperty))
      .ToString();
}