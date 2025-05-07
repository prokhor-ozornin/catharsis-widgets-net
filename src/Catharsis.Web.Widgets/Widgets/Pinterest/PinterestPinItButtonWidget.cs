using System.Web;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPinterestPinItButtonWidget"/>
public class PinterestPinItButtonWidget : WebWidget, IPinterestPinItButtonWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ColorValue { get; set; } = "gray";

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual PinterestPinItButtonPinCountPosition CounterValue { get; set; } = PinterestPinItButtonPinCountPosition.None;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string DescriptionValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ImageValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string LanguageValue { get; set; } = "en";

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual PinterestPinItButtonShape ShapeValue { get; set; } = PinterestPinItButtonShape.Rectangular;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual PinterestPinItButtonSize SizeValue { get; set; } = PinterestPinItButtonSize.Small;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string UrlValue { get; set; }

  /// <summary>
  ///   <para>Background color of the button.</para>
  /// </summary>
  /// <param name="color">Button's color.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
  public virtual IPinterestPinItButtonWidget Color(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    ColorValue = color;
    return this;
  }

  /// <summary>
  ///   <para>Position of button's pin counter.</para>
  /// </summary>
  /// <param name="position">Pin counter's position.</param>
  /// <returns>Reference to the current widget.</returns>
  public virtual IPinterestPinItButtonWidget Counter(PinterestPinItButtonPinCountPosition position)
  {
    CounterValue = position;
    return this;
  }

  /// <summary>
  ///   <para>Description of the "pinned" image.</para>
  /// </summary>
  /// <param name="description">Pin's description.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="description"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="description"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public virtual IPinterestPinItButtonWidget Description(string description)
  {
    if (description is null) throw new ArgumentNullException(nameof(description));
    if (description.IsEmpty()) throw new ArgumentException(nameof(description));

    DescriptionValue = description;
    return this;
  }

  /// <summary>
  ///   <para>URL address of the "pinned" image.</para>
  /// </summary>
  /// <param name="image">Pin's image URL.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="image"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="image"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public virtual IPinterestPinItButtonWidget Image(string image)
  {
    if (image is null) throw new ArgumentNullException(nameof(image));
    if (image.IsEmpty()) throw new ArgumentException(nameof(image));

    ImageValue = image;
    return this;
  }

  /// <summary>
  ///   <para>Language of button's label.</para>
  /// </summary>
  /// <param name="language">Button's text language.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="language"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="language"/> is <see cref="string.Empty"/> string.</exception>
  public virtual IPinterestPinItButtonWidget Language(string language)
  {
    if (language is null) throw new ArgumentNullException(nameof(language));
    if (language.IsEmpty()) throw new ArgumentException(nameof(language));

    LanguageValue = language;
    return this;
  }

  /// <summary>
  ///   <para>Shape of the button.</para>
  /// </summary>
  /// <param name="shape">Button's shape.</param>
  /// <returns>Reference to the current widget.</returns>
  public virtual IPinterestPinItButtonWidget Shape(PinterestPinItButtonShape shape)
  {
    ShapeValue = shape;
    return this;
  }

  /// <summary>
  ///   <para>Size of the button.</para>
  /// </summary>
  /// <param name="size">Button's size.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <remarks>Actual vertical size in pixels also depends on the button's shape.</remarks>
  public virtual IPinterestPinItButtonWidget Size(PinterestPinItButtonSize size)
  {
    SizeValue = size;
    return this;
  }
    
  /// <summary>
  ///   <para>URL address of target web page for the button.</para>
  /// </summary>
  /// <param name="url">Button's target web page.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public virtual IPinterestPinItButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlValue = url;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new PinterestPinItButtonWidget
  {
    ColorValue = ColorValue,
    CounterValue = CounterValue,
    DescriptionValue = DescriptionValue,
    ImageValue = ImageValue,
    LanguageValue = LanguageValue,
    ShapeValue = ShapeValue,
    SizeValue = SizeValue,
    UrlValue = UrlValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (UrlValue.IsUnset() || ImageValue.IsUnset() || DescriptionValue.IsUnset())
    {
      return string.Empty;
    }

    byte height = 0;

    height = SizeValue switch
    {
      PinterestPinItButtonSize.Large => ShapeValue switch
      {
        PinterestPinItButtonShape.Circular => 32,
        PinterestPinItButtonShape.Rectangular => 28,
        _ => height
      },
      PinterestPinItButtonSize.Small => ShapeValue switch
      {
        PinterestPinItButtonShape.Circular => 16,
        PinterestPinItButtonShape.Rectangular => 20,
        _ => height
      },
      _ => height
    };

    var shape = ShapeValue switch
    {
      PinterestPinItButtonShape.Rectangular => "rect",
      PinterestPinItButtonShape.Circular => "round",
      _ => string.Empty
    };

    return new TagBuilder("a")
      .Attribute("href", $"http://www.pinterest.com/pin/create/button/?url=${HttpUtility.UrlEncode(UrlValue)}&media=${HttpUtility.UrlEncode(ImageValue)}&description=${HttpUtility.UrlEncode(DescriptionValue)}")
      .Attribute("data-pin-do", "buttonPin")
      .Attribute("data-pin-lang", ShapeValue == PinterestPinItButtonShape.Rectangular ? LanguageValue : null)
      .Attribute("data-pin-config", ShapeValue == PinterestPinItButtonShape.Rectangular ? CounterValue.ToString().ToLowerInvariant() : null)
      .Attribute("data-pin-color", ShapeValue == PinterestPinItButtonShape.Rectangular ? ColorValue : null)
      .Attribute("data-pin-height", height)
      .Attribute("data-pin-shape", shape)
      .Html($"<img src=\"http://assets.pinterest.com/images/pidgets/pinit_fg_${LanguageValue}_${shape}_${ColorValue}_${height}.png\"/>")
      .ToString();
  }
}