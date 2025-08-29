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

  /// <inheritdoc cref="IMailRuLikeButtonWidget.Counter(bool)"/>
  public virtual IMailRuLikeButtonWidget Counter(bool enabled)
  {
    CounterValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IMailRuLikeButtonWidget.CounterPosition(string)"/>
  public virtual IMailRuLikeButtonWidget CounterPosition(string position)
  {
    if (position is null) throw new ArgumentNullException(nameof(position));
    if (position.IsEmpty()) throw new ArgumentException(nameof(position));

    CounterPositionValue = position;
    return this;
  }

  /// <inheritdoc cref="IMailRuLikeButtonWidget.Layout(byte)"/>
  public virtual IMailRuLikeButtonWidget Layout(byte layout)
  {
    LayoutValue = layout;
    return this;
  }

  /// <inheritdoc cref="IMailRuLikeButtonWidget.Size(string)"/>
  public virtual IMailRuLikeButtonWidget Size(string size)
  {
    SizeValue = size;
    return this;
  }

  /// <inheritdoc cref="IMailRuLikeButtonWidget.Text(bool)"/>
  public virtual IMailRuLikeButtonWidget Text(bool enabled)
  {
    TextValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IMailRuLikeButtonWidget.Type(string)"/>
  public IMailRuLikeButtonWidget Type(string type)
  {
    if (type is null) throw new ArgumentNullException(nameof(type));
    if (type.IsEmpty()) throw new ArgumentException(nameof(type));

    TypeValue = type;
    return this;
  }

  /// <inheritdoc cref="IMailRuLikeButtonWidget.TextType(byte)"/>
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