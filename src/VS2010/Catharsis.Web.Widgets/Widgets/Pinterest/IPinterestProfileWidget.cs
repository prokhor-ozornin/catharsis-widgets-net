using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Pinterest Profile widget with user's latest pins.</para>
  ///   <para>Requires Pinterest scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="http://business.pinterest.com/widget-builder/#do_embed_user"/>
  /// <seealso cref="IWidgetsScriptsRendererExtensions.Pinterest(IWidgetsScriptsRenderer)"/>
  public interface IPinterestProfileWidget : IHtmlWidget
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
    ///   <para>Pinterest user account.</para>
    /// </summary>
    /// <returns>Account name.</returns>
    string Account();

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
    ///   <para>Total height of profile area in pixels.</para>
    /// </summary>
    /// <returns>Areas's height.</returns>
    string Height();

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
    ///   <para>Total width of profile area in pixels.</para>
    /// </summary>
    /// <returns>Area's width.</returns>
    string Width();

    /// <summary>
    ///   <para>Width of profile area's image in pixels.</para>
    /// </summary>
    /// <param name="width">Area's image width.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>Min: 60; leave blank for 92.</remarks>
    IPinterestProfileWidget Image(string width);

    /// <summary>
    ///   <para>Width of profile area's image in pixels.</para>
    /// </summary>
    /// <returns>Area's image width.</returns>
    string Image();
  }
}