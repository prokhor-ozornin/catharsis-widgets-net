using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  public interface IInlineImageWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="contents"></param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="contents"/> is a <c>null</c> reference.</exception>
    IInlineImageWidget Contents(byte[] contents);

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="format"></param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="format"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="format"/> is <see cref="string.Empty"/> string.</exception>
    IInlineImageWidget Format(string format);
  }
}