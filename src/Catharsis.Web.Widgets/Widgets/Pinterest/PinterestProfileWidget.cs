using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPinterestProfileWidget"/>
public class PinterestProfileWidget : WebWidget, IPinterestProfileWidget
{
  private string account;
  private string height;
  private string width;
  private string image;

  /// <inheritdoc cref="IPinterestProfileWidget.Account(string)"/>
  public IPinterestProfileWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    this.account = account;
    return this;
  }

  /// <inheritdoc cref="IPinterestProfileWidget.Account()"/>
  public string Account() => account;

  /// <inheritdoc cref="IPinterestProfileWidget.Height(string)"/>
  public IPinterestProfileWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    this.height = height;
    return this;
  }

  /// <inheritdoc cref="IPinterestProfileWidget.Height()"/>
  public string Height() => height;

  /// <inheritdoc cref="IPinterestProfileWidget.Width(string)"/>
  public IPinterestProfileWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;
    return this;
  }

  /// <inheritdoc cref="IPinterestProfileWidget.Width()"/>
  public string Width() => width;

  /// <inheritdoc cref="IPinterestProfileWidget.Image(string)"/>
  public IPinterestProfileWidget Image(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    image = width;
    return this;
  }

  /// <inheritdoc cref="IPinterestProfileWidget.Image()"/>
  public string Image() => image;

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