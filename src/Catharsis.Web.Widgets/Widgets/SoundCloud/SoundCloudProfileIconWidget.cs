using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ISoundCloudProfileIconWidget"/>
public class SoundCloudProfileIconWidget : WebWidget, ISoundCloudProfileIconWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AccountValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ColorValue { get; set; } = "orange_white";

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual short SizeValue { get; set; } = (short) SoundCloudProfileIconSize.Size32;

  /// <inheritdoc cref="ISoundCloudProfileIconWidget.Account(string)"/>
  public virtual ISoundCloudProfileIconWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountValue = account;
    return this;
  }

  /// <inheritdoc cref="ISoundCloudProfileIconWidget.Color(string)"/>
  public virtual ISoundCloudProfileIconWidget Color(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    ColorValue = color;
    return this;
  }

  /// <inheritdoc cref="ISoundCloudProfileIconWidget.Size(short)"/>
  public virtual ISoundCloudProfileIconWidget Size(short size)
  {
    SizeValue = size;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new SoundCloudProfileIconWidget
  {
    AccountValue = AccountValue,
    ColorValue = ColorValue,
    SizeValue = SizeValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => AccountValue.IsUnset() ? string.Empty : new TagBuilder("iframe")
      .Attribute("allowtransparency", true)
      .Attribute("frameborder", 0)
      .Attribute("scrolling", "no")
      .Attribute("style", string.Format("width: {0}px; height: {0}px;", SizeValue))
      .Attribute("src", $"https://w.soundcloud.com/icon/?url=http://soundcloud.com/${AccountValue}&color=${ColorValue}&size=${SizeValue}")
      .ToString();
}