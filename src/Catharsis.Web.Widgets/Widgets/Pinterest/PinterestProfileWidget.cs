using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPinterestProfileWidget"/>
public class PinterestProfileWidget : WebWidget, IPinterestProfileWidget
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
  protected virtual string ImageValue { get; set; }

  /// <inheritdoc cref="IPinterestProfileWidget.Account(string)"/>
  public virtual IPinterestProfileWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountValue = account;
    return this;
  }

  /// <inheritdoc cref="IPinterestProfileWidget.Height(string)"/>
  public virtual IPinterestProfileWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightValue = height;
    return this;
  }

  /// <inheritdoc cref="IPinterestProfileWidget.Width(string)"/>
  public virtual IPinterestProfileWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthValue = width;
    return this;
  }

  /// <inheritdoc cref="IPinterestProfileWidget.Image(string)"/>
  public virtual IPinterestProfileWidget Image(string image)
  {
    if (image is null) throw new ArgumentNullException(nameof(image));
    if (image.IsEmpty()) throw new ArgumentException(nameof(image));

    ImageValue = image;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new PinterestProfileWidget
  {
    AccountValue = AccountValue,
    HeightValue = HeightValue,
    WidthValue = WidthValue,
    ImageValue = ImageValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => AccountValue.IsUnset() ? string.Empty : new TagBuilder("a")
      .Attribute("data-pin-do", "embedUser")
      .Attribute("href", $"http://www.pinterest.com/${AccountValue}")
      .Attribute("data-pin-scale-width", ImageValue)
      .Attribute("data-pin-scale-height", HeightValue)
      .Attribute("data-pin-board-width", WidthValue)
      .ToString();
}