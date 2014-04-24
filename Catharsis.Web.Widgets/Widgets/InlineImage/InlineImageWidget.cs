using System;
using System.Web.Mvc;
using Catharsis.Commons;
using Convert = System.Convert;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders inline HTML image with BASE64-encoded binary data.</para>
  /// </summary>
  public class InlineImageWidget : HtmlWidget, IInlineImageWidget
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
      Assertion.NotNull(contents);

      this.contents = contents;
      return this;
    }

    /// <summary>
    ///   <para>MIME content-type of image.</para>
    /// </summary>
    /// <param name="format">Image type.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="format"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="format"/> is <see cref="string.Empty"/> string.</exception>
    public IInlineImageWidget Format(string format)
    {
      Assertion.NotEmpty(format);

      this.format = format;
      return this;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (contents == null)
      {
        return string.Empty;
      }

      return new TagBuilder("img")
        .Attribute("src", "data:{1};base64,{0}".FormatSelf(Convert.ToBase64String(this.contents), this.format.IsEmpty() ? "image" : this.format))
        .ToString();
    }
  }
}