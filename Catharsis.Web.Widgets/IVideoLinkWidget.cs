using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Represents hyperlink widget to custom video.</para>
  /// </summary>
  public interface IVideoLinkWidget<T> : IHtmlWidget where T : IVideoLinkWidget<T>
  {
    /// <summary>
    ///   <para>Identifier of video.</para>
    /// </summary>
    /// <param name="id">Identifier of video.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    T Id(string id);
  }
}