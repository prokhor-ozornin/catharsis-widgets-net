using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Represents custom embedded video widget.</para>
  /// </summary>
  public interface IVideoWidget<T> : IHtmlWidget where T : IVideoWidget<T>
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

    /// <summary>
    ///   <para>Identifier of video.</para>
    /// </summary>
    /// <returns>Identifier of video.</returns>
    string Id();
    
    /// <summary>
    ///   <para>Height of video control.</para>
    /// </summary>
    /// <param name="height">Height of video.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    T Height(string height);

    /// <summary>
    ///   <para>Height of video control.</para>
    /// </summary>
    /// <returns>Height of video.</returns>
    string Height();

    /// <summary>
    ///   <para>Width of video control.</para>
    /// </summary>
    /// <param name="width">Width of video.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    T Width(string width);

    /// <summary>
    ///   <para>Width of video control.</para>
    /// </summary>
    /// <returns>Width of video.</returns>
    string Width();
  }
}