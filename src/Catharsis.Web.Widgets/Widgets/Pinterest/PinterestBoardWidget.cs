using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPinterestBoardWidget"/>
public class PinterestBoardWidget : WebWidget, IPinterestBoardWidget
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
  protected virtual string IdProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ImageProperty { get; set; }

  /// <inheritdoc cref="IPinterestBoardWidget.Account(string)"/>
  public virtual IPinterestBoardWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;
    return this;
  }

  /// <inheritdoc cref="IPinterestBoardWidget.Height(string)"/>
  public virtual IPinterestBoardWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;
    return this;
  }

  /// <inheritdoc cref="IPinterestBoardWidget.Width(string)"/>
  public virtual IPinterestBoardWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;
    return this;
  }

  /// <inheritdoc cref="IPinterestBoardWidget.Id(string)"/>
  public virtual IPinterestBoardWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    IdProperty = id;
    return this;
  }

  /// <inheritdoc cref="IPinterestBoardWidget.Image(string)"/>
  public virtual IPinterestBoardWidget Image(string image)
  {
    if (image is null) throw new ArgumentNullException(nameof(image));
    if (image.IsEmpty()) throw new ArgumentException(nameof(image));

    ImageProperty = image;
    return this;
  }

  public override object Clone() => new PinterestBoardWidget { };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => AccountProperty.IsUnset() || IdProperty.IsUnset() ? string.Empty : new TagBuilder("a")
      .Attribute("data-pin-do", "embedBoard")
      .Attribute("href", $"http://www.pinterest.com/${AccountProperty}/{IdProperty}")
      .Attribute("data-pin-scale-width", ImageProperty)
      .Attribute("data-pin-scale-height", HeightProperty)
      .Attribute("data-pin-board-width", WidthProperty)
      .ToString();
}