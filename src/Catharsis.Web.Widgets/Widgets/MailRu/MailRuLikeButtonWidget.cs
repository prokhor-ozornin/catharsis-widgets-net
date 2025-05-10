using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IMailRuLikeButtonWidget"/>
public class MailRuLikeButtonWidget : WebWidget, IMailRuLikeButtonWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TypeValue { get; set; } = "combo";

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string SizeValue { get; set; } = "20";

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte LayoutValue { get; set; } = (byte) MailRuLikeButtonLayout.First;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool TextValue { get; set; } = true;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte TextTypeValue { get; set; } = (byte) MailRuLikeButtonTextType.First;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool CounterValue { get; set; } = true;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string CounterPositionValue { get; set; } = nameof(MailRuLikeButtonCounterPosition.Right).ToLowerInvariant();

  /// <summary>
  ///   <para>Whether to render share counter next to a button. Default is <c>true</c>.</para>
  /// </summary>
  /// <param name="enabled"><c>true</c> to show share counter, <c>false</c> to hide.</param>
  /// <returns>Reference to the current widget.</returns>
  public virtual IMailRuLikeButtonWidget Counter(bool enabled)
  {
    CounterValue = enabled;
    return this;
  }

  /// <summary>
  ///   <para>Position of a share counter.</para>
  /// </summary>
  /// <param name="position">Position of a counter.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="position"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="position"/> is <see cref="string.Empty"/> string.</exception>
  public virtual IMailRuLikeButtonWidget CounterPosition(string position)
  {
    if (position is null) throw new ArgumentNullException(nameof(position));
    if (position.IsEmpty()) throw new ArgumentException(nameof(position));

    CounterPositionValue = position;
    return this;
  }

  /// <summary>
  ///   <para>Visual layout/appearance of button.</para>
  /// </summary>
  /// <param name="layout">Visual layout of button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="layout"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="layout"/> is <see cref="string.Empty"/> string.</exception>
  public virtual IMailRuLikeButtonWidget Layout(byte layout)
  {
    LayoutValue = layout;
    return this;
  }

  /// <summary>
  ///   <para>Vertical size of button.</para>
  /// </summary>
  /// <param name="size">Vertical size of button.</param>
  /// <returns>Reference to the current widget.</returns>
  public virtual IMailRuLikeButtonWidget Size(string size)
  {
    SizeValue = size;
    return this;
  }

  /// <summary>
  ///   <para>Whether to show text label on button. Default is <c>true</c>.</para>
  /// </summary>
  /// <param name="enabled"><c>true</c> to show text label, <c>false</c> to hide.</param>
  /// <returns>Reference to the current widget.</returns>
  public virtual IMailRuLikeButtonWidget Text(bool enabled)
  {
    TextValue = enabled;
    return this;
  }

  /// <summary>
  ///   <para>Type of button.</para>
  /// </summary>
  /// <param name="type">Type of button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="type"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="type"/> is <see cref="string.Empty"/> string.</exception>
  public IMailRuLikeButtonWidget Type(string type)
  {
    if (type is null) throw new ArgumentNullException(nameof(type));
    if (type.IsEmpty()) throw new ArgumentException(nameof(type));

    TypeValue = type;
    return this;
  }

  /// <summary>
  ///   <para>Type of text label to show on button.</para>
  /// </summary>
  /// <param name="type">Type of text label.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="type"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="type"/> is <see cref="string.Empty"/> string.</exception>
  public IMailRuLikeButtonWidget TextType(byte type)
  {
    TextTypeValue = type;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new MailRuLikeButtonWidget
  {
    TypeValue = TypeValue,
    SizeValue = SizeValue,
    LayoutValue = LayoutValue,
    TextValue = TextValue,
    TextTypeValue = TextTypeValue,
    CounterValue = CounterValue,
    CounterPositionValue = CounterPositionValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    var config = new Dictionary<string, object>
    {
      { "sz", SizeValue },
      { "st", LayoutValue },
      { "tp", TypeValue }
    };

    if (!CounterValue)
    {
      config["nc"] = 1;
    }
    else if (CounterPositionValue is not null && string.Equals(CounterPositionValue, nameof(MailRuLikeButtonCounterPosition.Upper), StringComparison.InvariantCultureIgnoreCase))
    {
      config["vt"] = 1;
    }

    if (!TextValue)
    {
      config["nt"] = 1;
    }
    else
    {
      config["cm"] = TextTypeValue;
      config["ck"] = TextTypeValue;
    }

    return new TagBuilder("a")
      .Attribute("target", "_blank")
      .Attribute("href", "http://connect.mail.ru/share")
      .Attribute("data-mrc-config", config.Json())
      .CssClass("mrc__plugin_uber_like_button")
      .Html("��������")
      .ToString();
  }
}