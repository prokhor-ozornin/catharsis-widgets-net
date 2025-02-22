using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPinterestProfileWidget"/>
public class PinterestProfileWidget : WebWidget, IPinterestProfileWidget
{
  private string AccountProperty { get; set; }
  private string HeightProperty { get; set; }
  private string WidthProperty { get; set; }
  private string ImageProperty { get; set; }

  /// <inheritdoc cref="IPinterestProfileWidget.Account(string)"/>
  public IPinterestProfileWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;
    return this;
  }

  /// <inheritdoc cref="IPinterestProfileWidget.Account()"/>
  public string Account() => AccountProperty;

  /// <inheritdoc cref="IPinterestProfileWidget.Height(string)"/>
  public IPinterestProfileWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;
    return this;
  }

  /// <inheritdoc cref="IPinterestProfileWidget.Height()"/>
  public string Height() => HeightProperty;

  /// <inheritdoc cref="IPinterestProfileWidget.Width(string)"/>
  public IPinterestProfileWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;
    return this;
  }

  /// <inheritdoc cref="IPinterestProfileWidget.Width()"/>
  public string Width() => WidthProperty;

  /// <inheritdoc cref="IPinterestProfileWidget.Image(string)"/>
  public IPinterestProfileWidget Image(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    ImageProperty = width;
    return this;
  }

  /// <inheritdoc cref="IPinterestProfileWidget.Image()"/>
  public string Image() => ImageProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  /// <returns>Widget's HTML markup.</returns>
  public override string ToHtml()
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