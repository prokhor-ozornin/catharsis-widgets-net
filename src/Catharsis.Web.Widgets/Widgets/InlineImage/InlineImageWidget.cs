using Catharsis.Extensions;
using Convert = System.Convert;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IInlineImageWidget"/>
public class InlineImageWidget : WebWidget, IInlineImageWidget
{
  private byte[] contents;
  private string format;

  /// <summary>
  ///   <para>Binary contents of image.</para>
  /// </summary>
  /// <param name="contents">Image data.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="contents"/> is a <c>null</c> reference.</exception>
  public IInlineImageWidget Contents(byte[] contents)
  {
    this.contents = contents ?? throw new ArgumentNullException(nameof(contents));
    return this;
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <returns></returns>
  public byte[] Contents() => contents;

  /// <summary>
  ///   <para>MIME content-type of image.</para>
  /// </summary>
  /// <param name="format">Image type.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="format"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="format"/> is <see cref="string.Empty"/> string.</exception>
  public IInlineImageWidget Format(string format)
  {
    if (format is null) throw new ArgumentNullException(nameof(format));
    if (format.IsEmpty()) throw new ArgumentException(nameof(format));

    this.format = format;
    return this;
  }

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