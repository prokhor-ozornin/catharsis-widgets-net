using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPinterestProfileWidget"/>
public class PinterestProfileWidget : WebWidget, IPinterestProfileWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AccountProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HeightProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ImageProperty { get; set; }

  /// <inheritdoc cref="IPinterestProfileWidget.Account(string)"/>
  public virtual IPinterestProfileWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;
    return this;
  }

  /// <inheritdoc cref="IPinterestProfileWidget.Height(string)"/>
  public virtual IPinterestProfileWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;
    return this;
  }

  /// <inheritdoc cref="IPinterestProfileWidget.Width(string)"/>
  public virtual IPinterestProfileWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;
    return this;
  }

  /// <inheritdoc cref="IPinterestProfileWidget.Image(string)"/>
  public virtual IPinterestProfileWidget Image(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    ImageProperty = width;
    return this;
  }

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  /// <returns>Widget's HTML markup.</returns>
  public override string ToHtml() => AccountProperty.IsUnset() ? string.Empty : new TagBuilder("a")
      .Attribute("data-pin-do", "embedUser")
      .Attribute("href", $"http://www.pinterest.com/${AccountProperty}")
      .Attribute("data-pin-scale-width", ImageProperty)
      .Attribute("data-pin-scale-height", HeightProperty)
      .Attribute("data-pin-board-width", WidthProperty)
      .ToString();
}