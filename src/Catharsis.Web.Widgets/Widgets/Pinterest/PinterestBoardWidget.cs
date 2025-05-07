using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPinterestBoardWidget"/>
public class PinterestBoardWidget : WebWidget, IPinterestBoardWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AccountValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HeightValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string IdValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ImageValue { get; set; }

  /// <inheritdoc cref="IPinterestBoardWidget.Account(string)"/>
  public virtual IPinterestBoardWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountValue = account;
    return this;
  }

  /// <inheritdoc cref="IPinterestBoardWidget.Height(string)"/>
  public virtual IPinterestBoardWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightValue = height;
    return this;
  }

  /// <inheritdoc cref="IPinterestBoardWidget.Width(string)"/>
  public virtual IPinterestBoardWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthValue = width;
    return this;
  }

  /// <inheritdoc cref="IPinterestBoardWidget.Id(string)"/>
  public virtual IPinterestBoardWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    IdValue = id;
    return this;
  }

  /// <inheritdoc cref="IPinterestBoardWidget.Image(string)"/>
  public virtual IPinterestBoardWidget Image(string image)
  {
    if (image is null) throw new ArgumentNullException(nameof(image));
    if (image.IsEmpty()) throw new ArgumentException(nameof(image));

    ImageValue = image;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new PinterestBoardWidget
  {
    AccountValue = AccountValue,
    HeightValue = HeightValue,
    WidthValue = WidthValue,
    IdValue = IdValue,
    ImageValue = ImageValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => AccountValue.IsUnset() || IdValue.IsUnset() ? string.Empty : new TagBuilder("a")
      .Attribute("data-pin-do", "embedBoard")
      .Attribute("href", $"http://www.pinterest.com/${AccountValue}/{IdValue}")
      .Attribute("data-pin-scale-width", ImageValue)
      .Attribute("data-pin-scale-height", HeightValue)
      .Attribute("data-pin-board-width", WidthValue)
      .ToString();
}