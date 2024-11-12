using System.Web.Mvc;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPinterestProfileWidget"/>
public sealed class PinterestProfileWidget : HtmlWidget, IPinterestProfileWidget
{
  private string account;
  private string height;
  private string width;
  private string image;

  /// <summary>
  ///   <para>Pinterest user account.</para>
  /// </summary>
  /// <param name="account">Account name.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public IPinterestProfileWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    this.account = account;
    return this;
  }

  /// <summary>
  ///   <para>Pinterest user account.</para>
  /// </summary>
  /// <returns>Account name.</returns>
  public string Account() => account;

  /// <summary>
  ///   <para>Total height of profile area in pixels.</para>
  /// </summary>
  /// <param name="height">Areas's height.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
  /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>Min: 60; leave blank for 175.</remarks>
  public IPinterestProfileWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    this.height = height;
    return this;
  }

  /// <summary>
  ///   <para>Total height of profile area in pixels.</para>
  /// </summary>
  /// <returns>Areas's height.</returns>
  public string Height() => height;

  /// <summary>
  ///   <para>Total width of profile area in pixels.</para>
  /// </summary>
  /// <param name="width">Area's width.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>Min: 130; leave blank for auto.</remarks>
  public IPinterestProfileWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;
    return this;
  }

  /// <summary>
  ///   <para>Total width of profile area in pixels.</para>
  /// </summary>
  /// <returns>Area's width.</returns>
  public string Width() => width;

  /// <summary>
  ///   <para>Width of profile area's image in pixels.</para>
  /// </summary>
  /// <param name="width">Area's image width.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>Min: 60; leave blank for 92.</remarks>
  public IPinterestProfileWidget Image(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    image = width;
    return this;
  }

  /// <summary>
  ///   <para>Width of profile area's image in pixels.</para>
  /// </summary>
  /// <returns>Area's image width.</returns>
  public string Image() => image;

  /// <inheritdoc cref="IHtmlWidget.ToHtmlString()"/>
  /// <returns>Widget's HTML markup.</returns>
  public override string ToHtmlString()
  {
    if (Account().IsEmpty())
    {
      return string.Empty;
    }

    return new TagBuilder("a")
      .Attribute("data-pin-do", "embedUser")
      .Attribute("href", $"http://www.pinterest.com/${Account()}")
      .Attribute("data-pin-scale-width", Image())
      .Attribute("data-pin-scale-height", Height())
      .Attribute("data-pin-board-width", Width())
      .ToString();
  }
}