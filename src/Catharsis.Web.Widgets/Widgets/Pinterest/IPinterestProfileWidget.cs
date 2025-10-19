namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Renders Pinterest Profile widget with user's latest pins.</para>
///   <para>Requires Pinterest scripts bundle to be included.</para>
/// </summary>
/// <seealso href="http://business.pinterest.com/widget-builder/#do_embed_user"/>
/// <seealso cref="IWidgetsScriptsRendererExtensions.Pinterest(IWidgetsScriptsRenderer)"/>
public interface IPinterestProfileWidget : IWebWidget
{
  /// <summary>
  ///   <para>Pinterest user account.</para>
  /// </summary>
  /// <param name="account">Account name.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  IPinterestProfileWidget Account(string account);

  /// <summary>
  ///   <para>Total height of profile area in pixels.</para>
  /// </summary>
  /// <param name="height">Areas's height.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
  /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>Min: 60; leave blank for 175.</remarks>
  IPinterestProfileWidget Height(string height);

  /// <summary>
  ///   <para>Total width of profile area in pixels.</para>
  /// </summary>
  /// <param name="width">Area's width.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>Min: 130; leave blank for auto.</remarks>
  IPinterestProfileWidget Width(string width);

  /// <summary>
  ///   <para>Width of profile area's image in pixels.</para>
  /// </summary>
  /// <param name="image">Area's image width.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="image"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="image"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>Min: 60; leave blank for 92.</remarks>
  IPinterestProfileWidget Image(string image);
}