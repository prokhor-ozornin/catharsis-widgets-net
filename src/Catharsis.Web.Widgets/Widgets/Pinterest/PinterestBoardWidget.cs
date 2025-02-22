using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPinterestBoardWidget"/>
public class PinterestBoardWidget : WebWidget, IPinterestBoardWidget
{
  private string AccountProperty { get; set; }
  private string HeightProperty { get; set; }
  private string WidthProperty { get; set; }
  private string IdProperty { get; set; }
  private string ImageProperty { get; set; }

  /// <inheritdoc cref="IPinterestBoardWidget.Account(string)"/>
  public IPinterestBoardWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;
    return this;
  }

  /// <inheritdoc cref="IPinterestBoardWidget.Account()"/>
  public string Account() => AccountProperty;

  /// <inheritdoc cref="IPinterestBoardWidget.Height(string)"/>
  public IPinterestBoardWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;
    return this;
  }

  /// <inheritdoc cref="IPinterestBoardWidget.Height()"/>
  public string Height() => HeightProperty;

  /// <inheritdoc cref="IPinterestBoardWidget.Width(string)"/>
  public IPinterestBoardWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;
    return this;
  }

  /// <inheritdoc cref="IPinterestBoardWidget.Width()"/>
  public string Width() => WidthProperty;

  /// <inheritdoc cref="IPinterestBoardWidget.Id(string)"/>
  public IPinterestBoardWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    IdProperty = id;
    return this;
  }

  /// <inheritdoc cref="IPinterestBoardWidget.Id()"/>
  public string Id() => IdProperty;

  /// <inheritdoc cref="IPinterestBoardWidget.Image(string)"/>
  public IPinterestBoardWidget Image(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    ImageProperty = width;
    return this;
  }

  /// <inheritdoc cref="IPinterestBoardWidget.Image()"/>
  public string Image() => ImageProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    if (Account().IsEmpty() || Id().IsEmpty())
    {
      return string.Empty;
    }

    return new TagBuilder("a")
      .Attribute("data-pin-do", "embedBoard")
      .Attribute("href", $"http://www.pinterest.com/${Account()}/{Id()}")
      .Attribute("data-pin-scale-width", Image())
      .Attribute("data-pin-scale-height", Height())
      .Attribute("data-pin-board-width", Width())
      .ToString();
  }
}