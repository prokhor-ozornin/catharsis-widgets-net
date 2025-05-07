using Catharsis.Extensions;
using Convert = System.Convert;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IInlineImageWidget"/>
public class InlineImageWidget : WebWidget, IInlineImageWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte[] ContentsValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string FormatValue { get; set; }

  /// <inheritdoc cref="IInlineImageWidget.Contents(byte[])"/>
  public virtual IInlineImageWidget Contents(byte[] contents)
  {
    ContentsValue = contents ?? throw new ArgumentNullException(nameof(contents));
    return this;
  }

  /// <inheritdoc cref="IInlineImageWidget.Format(string)"/>
  public virtual IInlineImageWidget Format(string format)
  {
    if (format is null) throw new ArgumentNullException(nameof(format));
    if (format.IsEmpty()) throw new ArgumentException(nameof(format));

    FormatValue = format;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new InlineImageWidget
  {
    ContentsValue = ContentsValue,
    FormatValue = FormatValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => ContentsValue is null ? string.Empty : 
    new TagBuilder("img")
      .Attribute("src", string.Format("data:{1};base64,{0}", Convert.ToBase64String(ContentsValue), FormatValue.IsUnset() ? "image" : FormatValue))
      .ToString();
}