using System.Web;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPinterestPinItButtonWidget"/>
public class PinterestPinItButtonWidget : WebWidget, IPinterestPinItButtonWidget
{
  private string ColorProperty { get; set; } = "gray";
  private PinterestPinItButtonPinCountPosition CounterProperty { get; set; } = PinterestPinItButtonPinCountPosition.None;
  private string DescriptionProperty { get; set; }
  private string ImageProperty { get; set; }
  private string LanguageProperty { get; set; } = "en";
  private PinterestPinItButtonShape ShapeProperty { get; set; } = PinterestPinItButtonShape.Rectangular;
  private PinterestPinItButtonSize SizeProperty { get; set; } = PinterestPinItButtonSize.Small;
  private string UrlProperty { get; set; }

  /// <summary>
  ///   <para>Background color of the button.</para>
  /// </summary>
  /// <param name="color">Button's color.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
  public IPinterestPinItButtonWidget Color(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    ColorProperty = color;
    return this;
  }

  /// <summary>
  ///   <para>Background color of the button.</para>
  /// </summary>
  /// <returns>Button's color.</returns>
  public string Color() => ColorProperty;

  /// <summary>
  ///   <para>Position of button's pin counter.</para>
  /// </summary>
  /// <param name="position">Pin counter's position.</param>
  /// <returns>Reference to the current widget.</returns>
  public IPinterestPinItButtonWidget Counter(PinterestPinItButtonPinCountPosition position)
  {
    CounterProperty = position;
    return this;
  }

  /// <summary>
  ///   <para>Position of button's pin counter.</para>
  /// </summary>
  /// <returns>Pin counter's position.</returns>
  public PinterestPinItButtonPinCountPosition Counter() => CounterProperty;

  /// <summary>
  ///   <para>Description of the "pinned" image.</para>
  /// </summary>
  /// <param name="description">Pin's description.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="description"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="description"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public IPinterestPinItButtonWidget Description(string description)
  {
    if (description is null) throw new ArgumentNullException(nameof(description));
    if (description.IsEmpty()) throw new ArgumentException(nameof(description));

    DescriptionProperty = description;
    return this;
  }

  /// <summary>
  ///   <para>Description of the "pinned" image.</para>
  /// </summary>
  /// <returns>Pin's description.</returns>
  public string Description() => DescriptionProperty;

  /// <summary>
  ///   <para>URL address of the "pinned" image.</para>
  /// </summary>
  /// <param name="url">Pin's image URL.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public IPinterestPinItButtonWidget Image(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    ImageProperty = url;
    return this;
  }

  /// <summary>
  ///   <para>URL address of the "pinned" image.</para>
  /// </summary>
  /// <returns>Pin's image URL.</returns>
  public string Image() => ImageProperty;

  /// <summary>
  ///   <para>Language of button's label.</para>
  /// </summary>
  /// <param name="language">Button's text language.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="language"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="language"/> is <see cref="string.Empty"/> string.</exception>
  public IPinterestPinItButtonWidget Language(string language)
  {
    if (language is null) throw new ArgumentNullException(nameof(language));
    if (language.IsEmpty()) throw new ArgumentException(nameof(language));

    LanguageProperty = language;
    return this;
  }

  /// <summary>
  ///   <para>Language of button's label.</para>
  /// </summary>
  /// <returns>Button's text language.</returns>
  public string Language() => LanguageProperty;

  /// <summary>
  ///   <para>Shape of the button.</para>
  /// </summary>
  /// <param name="shape">Button's shape.</param>
  /// <returns>Reference to the current widget.</returns>
  public IPinterestPinItButtonWidget Shape(PinterestPinItButtonShape shape)
  {
    ShapeProperty = shape;
    return this;
  }

  /// <summary>
  ///   <para>Shape of the button.</para>
  /// </summary>
  /// <returns>Button's shape.</returns>
  public PinterestPinItButtonShape Shape() => ShapeProperty;

  /// <summary>
  ///   <para>Size of the button.</para>
  /// </summary>
  /// <param name="size">Button's size.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <remarks>Actual vertical size in pixels also depends on the button's shape.</remarks>
  public IPinterestPinItButtonWidget Size(PinterestPinItButtonSize size)
  {
    SizeProperty = size;
    return this;
  }
    
  /// <summary>
  ///   <para>Size of the button.</para>
  /// </summary>
  /// <returns>Button's size.</returns>
  public PinterestPinItButtonSize Size() => SizeProperty;

  /// <summary>
  ///   <para>URL address of target web page for the button.</para>
  /// </summary>
  /// <param name="url">Button's target web page.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public IPinterestPinItButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlProperty = url;
    return this;
  }

  /// <summary>
  ///   <para>URL address of target web page for the button.</para>
  /// </summary>
  /// <returns>Button's target web page.</returns>
  public string Url() => UrlProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    if (Url().IsEmpty() || Image().IsEmpty() || Description().IsEmpty())
    {
      return string.Empty;
    }

    byte height = 0;

    height = Size() switch
    {
      PinterestPinItButtonSize.Large => Shape() switch
      {
        PinterestPinItButtonShape.Circular => 32,
        PinterestPinItButtonShape.Rectangular => 28,
        _ => height
      },
      PinterestPinItButtonSize.Small => Shape() switch
      {
        PinterestPinItButtonShape.Circular => 16,
        PinterestPinItButtonShape.Rectangular => 20,
        _ => height
      },
      _ => height
    };

    var shape = Shape() switch
    {
      PinterestPinItButtonShape.Rectangular => "rect",
      PinterestPinItButtonShape.Circular => "round",
      _ => string.Empty
    };

    return new TagBuilder("a")
      .Attribute("href", $"http://www.pinterest.com/pin/create/button/?url=${HttpUtility.UrlEncode(Url())}&media=${HttpUtility.UrlEncode(Image())}&description=${HttpUtility.UrlEncode(Description())}")
      .Attribute("data-pin-do", "buttonPin")
      .Attribute("data-pin-lang", Shape() == PinterestPinItButtonShape.Rectangular ? Language() : null)
      .Attribute("data-pin-config", Shape() == PinterestPinItButtonShape.Rectangular ? Counter().ToString().ToLowerInvariant() : null)
      .Attribute("data-pin-color", Shape() == PinterestPinItButtonShape.Rectangular ? Color() : null)
      .Attribute("data-pin-height", height)
      .Attribute("data-pin-shape", shape)
      .Html($"<img src=\"http://assets.pinterest.com/images/pidgets/pinit_fg_${Language()}_${shape}_${Color()}_${height}.png\"/>")
      .ToString();
  }
}