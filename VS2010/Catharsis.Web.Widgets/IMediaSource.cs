using System;
using System.Web;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Represents a media source for HTML video tag.</para>
  /// </summary>
  public interface IMediaSource : IHtmlString
  {
    /// <summary>
    ///   <para>Content-type of associated video.</para>
    /// </summary>
    /// <exception cref="ArgumentNullException">If <paramref name="value"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="value"/> is <see cref="string.Empty"/> string.</exception>
    string ContentType { get; set; }

    /// <summary>
    ///   <para>URL address of associated video.</para>
    /// </summary>
    /// <exception cref="ArgumentNullException">If <paramref name="value"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="value"/> is <see cref="string.Empty"/> string.</exception>
    string Url { get; set; }
  }
}