using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders inline HTML image with BASE64-encoded binary data.</para>
  /// </summary>
  public interface IInlineImageWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Binary contents of image.</para>
    /// </summary>
    /// <param name="contents">Image data.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="contents"/> is a <c>null</c> reference.</exception>
    IInlineImageWidget Contents(byte[] contents);

    /// <summary>
    ///   <para>MIME content-type of image.</para>
    /// </summary>
    /// <param name="format">Image type.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="format"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="format"/> is <see cref="string.Empty"/> string.</exception>
    IInlineImageWidget Format(string format);
  }
}