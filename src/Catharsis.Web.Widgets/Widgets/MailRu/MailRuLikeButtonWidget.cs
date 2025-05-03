using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IMailRuLikeButtonWidget"/>
public class MailRuLikeButtonWidget : WebWidget, IMailRuLikeButtonWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TypeProperty { get; set; } = "combo";

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string SizeProperty { get; set; } = "20";

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte LayoutProperty { get; set; } = (byte) MailRuLikeButtonLayout.First;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool TextProperty { get; set; } = true;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte TextTypeProperty { get; set; } = (byte) MailRuLikeButtonTextType.First;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool CounterProperty { get; set; } = true;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string CounterPositionProperty { get; set; } = nameof(MailRuLikeButtonCounterPosition.Right).ToLowerInvariant();

  /// <summary>
  ///   <para>Whether to render share counter next to a button. Default is <c>true</c>.</para>
  /// </summary>
  /// <param name="enabled"><c>true</c> to show share counter, <c>false</c> to hide.</param>
  /// <returns>Reference to the current widget.</returns>
  public virtual IMailRuLikeButtonWidget Counter(bool enabled)
  {
    CounterProperty = enabled;
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

    CounterPositionProperty = position;
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
    LayoutProperty = layout;
    return this;
  }

  /// <summary>
  ///   <para>Vertical size of button.</para>
  /// </summary>
  /// <param name="size">Vertical size of button.</param>
  /// <returns>Reference to the current widget.</returns>
  public virtual IMailRuLikeButtonWidget Size(string size)
  {
    SizeProperty = size;
    return this;
  }

  /// <summary>
  ///   <para>Whether to show text label on button. Default is <c>true</c>.</para>
  /// </summary>
  /// <param name="enabled"><c>true</c> to show text label, <c>false</c> to hide.</param>
  /// <returns>Reference to the current widget.</returns>
  public virtual IMailRuLikeButtonWidget Text(bool enabled)
  {
    TextProperty = enabled;
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

    TypeProperty = type;
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
    TextTypeProperty = type;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new MailRuLikeButtonWidget
  {
    TypeProperty = TypeProperty,
    SizeProperty = SizeProperty,
    LayoutProperty = LayoutProperty,
    TextProperty = TextProperty,
    TextTypeProperty = TextTypeProperty,
    CounterProperty = CounterProperty,
    CounterPositionProperty = CounterPositionProperty
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    var config = new Dictionary<string, object>
    {
      { "sz", SizeProperty },
      { "st", LayoutProperty },
      { "tp", TypeProperty }
    };

    if (!CounterProperty)
    {
      config["nc"] = 1;
    }
    else if (CounterPositionProperty is not null && string.Equals(CounterPositionProperty, MailRuLikeButtonCounterPosition.Upper.ToString(), StringComparison.InvariantCultureIgnoreCase))
    {
      config["vt"] = 1;
    }

    if (!TextProperty)
    {
      config["nt"] = 1;
    }
    else
    {
      config["cm"] = TextTypeProperty;
      config["ck"] = TextTypeProperty;
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