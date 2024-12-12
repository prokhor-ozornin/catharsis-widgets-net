using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IMailRuLikeButtonWidget"/>
public class MailRuLikeButtonWidget : WebWidget, IMailRuLikeButtonWidget
{
  private string type = "combo";
  private string size = "20";
  private byte layout = (byte) MailRuLikeButtonLayout.First;
  private bool text = true;
  private byte textType = (byte) MailRuLikeButtonTextType.First;
  private bool counter = true;
  private string counterPosition = MailRuLikeButtonCounterPosition.Right.ToString().ToLowerInvariant();

  /// <summary>
  ///   <para>Whether to render share counter next to a button. Default is <c>true</c>.</para>
  /// </summary>
  /// <param name="enabled"><c>true</c> to show share counter, <c>false</c> to hide.</param>
  /// <returns>Reference to the current widget.</returns>
  public IMailRuLikeButtonWidget Counter(bool enabled)
  {
    counter = enabled;
    return this;
  }

  /// <summary>
  ///   <para>Whether to render share counter next to a button. Default is <c>true</c>.</para>
  /// </summary>
  /// <returns><c>true</c> to show share counter, <c>false</c> to hide.</returns>
  public bool Counter() => counter;

  /// <summary>
  ///   <para>Position of a share counter.</para>
  /// </summary>
  /// <param name="position">Position of a counter.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="position"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="position"/> is <see cref="string.Empty"/> string.</exception>
  public IMailRuLikeButtonWidget CounterPosition(string position)
  {
    if (position is null) throw new ArgumentNullException(nameof(position));
    if (position.IsEmpty()) throw new ArgumentException(nameof(position));

    counterPosition = position;
    return this;
  }

  /// <summary>
  ///   <para>Position of a share counter.</para>
  /// </summary>
  /// <returns>Position of a counter.</returns>
  public string CounterPosition() => counterPosition;

  /// <summary>
  ///   <para>Visual layout/appearance of button.</para>
  /// </summary>
  /// <param name="layout">Visual layout of button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="layout"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="layout"/> is <see cref="string.Empty"/> string.</exception>
  public IMailRuLikeButtonWidget Layout(byte layout)
  {
    this.layout = layout;
    return this;
  }

  /// <summary>
  ///   <para>Visual layout/appearance of button.</para>
  /// </summary>
  /// <returns>Visual layout of button.</returns>
  public byte Layout() => layout;

  /// <summary>
  ///   <para>Vertical size of button.</para>
  /// </summary>
  /// <param name="size">Vertical size of button.</param>
  /// <returns>Reference to the current widget.</returns>
  public IMailRuLikeButtonWidget Size(string size)
  {
    this.size = size;
    return this;
  }

  /// <summary>
  ///   <para>Vertical size of button.</para>
  /// </summary>
  /// <returns>Vertical size of button.</returns>
  public string Size() => size;

  /// <summary>
  ///   <para>Whether to show text label on button. Default is <c>true</c>.</para>
  /// </summary>
  /// <param name="enabled"><c>true</c> to show text label, <c>false</c> to hide.</param>
  /// <returns>Reference to the current widget.</returns>
  public IMailRuLikeButtonWidget Text(bool enabled)
  {
    this.text = enabled;
    return this;
  }

  /// <summary>
  ///   <para>Whether to show text label on button. Default is <c>true</c>.</para>
  /// </summary>
  /// <returns><c>true</c> to show text label, <c>false</c> to hide.</returns>
  public bool Text() => text;

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

    this.type = type;
    return this;
  }

  /// <summary>
  ///   <para>Type of button.</para>
  /// </summary>
  /// <returns>Type of button.</returns>
  public string Type() => type;

  /// <summary>
  ///   <para>Type of text label to show on button.</para>
  /// </summary>
  /// <param name="type">Type of text label.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="type"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="type"/> is <see cref="string.Empty"/> string.</exception>
  public IMailRuLikeButtonWidget TextType(byte type)
  {
    textType = type;
    return this;
  }

  /// <summary>
  ///   <para>Type of text label to show on button.</para>
  /// </summary>
  /// <returns>Type of text label.</returns>
  public byte TextType() => textType;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    var config = new Dictionary<string, object>
    {
      { "sz", Size() },
      { "st", Layout() },
      { "tp", Type() }
    };

    if (!Counter())
    {
      config["nc"] = 1;
    }
    else if (CounterPosition() is not null && string.Equals(CounterPosition(), MailRuLikeButtonCounterPosition.Upper.ToString(), StringComparison.InvariantCultureIgnoreCase))
    {
      config["vt"] = 1;
    }

    if (!Text())
    {
      config["nt"] = 1;
    }
    else
    {
      config["cm"] = TextType();
      config["ck"] = TextType();
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