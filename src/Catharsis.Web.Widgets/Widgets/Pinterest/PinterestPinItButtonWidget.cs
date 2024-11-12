using System.Web;
using System.Web.Mvc;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPinterestPinItButtonWidget"/>
public sealed class PinterestPinItButtonWidget : HtmlWidget, IPinterestPinItButtonWidget
{
  private string color = "gray";
  private PinterestPinItButtonPinCountPosition counter = PinterestPinItButtonPinCountPosition.None;
  private string description;
  private string image;
  private string language = "en";
  private PinterestPinItButtonShape shape = PinterestPinItButtonShape.Rectangular;
  private PinterestPinItButtonSize size = PinterestPinItButtonSize.Small;
  private string url;

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

    this.color = color;
    return this;
  }

  /// <summary>
  ///   <para>Background color of the button.</para>
  /// </summary>
  /// <returns>Button's color.</returns>
  public string Color() => color;

  /// <summary>
  ///   <para>Position of button's pin counter.</para>
  /// </summary>
  /// <param name="position">Pin counter's position.</param>
  /// <returns>Reference to the current widget.</returns>
  public IPinterestPinItButtonWidget Counter(PinterestPinItButtonPinCountPosition position)
  {
    counter = position;
    return this;
  }

  /// <summary>
  ///   <para>Position of button's pin counter.</para>
  /// </summary>
  /// <returns>Pin counter's position.</returns>
  public PinterestPinItButtonPinCountPosition Counter() => counter;

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

    this.description = description;
    return this;
  }

  /// <summary>
  ///   <para>Description of the "pinned" image.</para>
  /// </summary>
  /// <returns>Pin's description.</returns>
  public string Description() => description;

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

    image = url;
    return this;
  }

  /// <summary>
  ///   <para>URL address of the "pinned" image.</para>
  /// </summary>
  /// <returns>Pin's image URL.</returns>
  public string Image() => image;

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

    this.language = language;
    return this;
  }

  /// <summary>
  ///   <para>Language of button's label.</para>
  /// </summary>
  /// <returns>Button's text language.</returns>
  public string Language() => language;

  /// <summary>
  ///   <para>Shape of the button.</para>
  /// </summary>
  /// <param name="shape">Button's shape.</param>
  /// <returns>Reference to the current widget.</returns>
  public IPinterestPinItButtonWidget Shape(PinterestPinItButtonShape shape)
  {
    this.shape = shape;
    return this;
  }

  /// <summary>
  ///   <para>Shape of the button.</para>
  /// </summary>
  /// <returns>Button's shape.</returns>
  public PinterestPinItButtonShape Shape() => shape;

  /// <summary>
  ///   <para>Size of the button.</para>
  /// </summary>
  /// <param name="size">Button's size.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <remarks>Actual vertical size in pixels also depends on the button's shape.</remarks>
  public IPinterestPinItButtonWidget Size(PinterestPinItButtonSize size)
  {
    this.size = size;
    return this;
  }
    
  /// <summary>
  ///   <para>Size of the button.</para>
  /// </summary>
  /// <returns>Button's size.</returns>
  public PinterestPinItButtonSize Size() => size;

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

    this.url = url;
    return this;
  }

  /// <summary>
  ///   <para>URL address of target web page for the button.</para>
  /// </summary>
  /// <returns>Button's target web page.</returns>
  public string Url() => url;

  /// <inheritdoc cref="IHtmlWidget.ToHtmlString()"/>
  public override string ToHtmlString()
  {
    if (Url().IsEmpty() || Image().IsEmpty() || Description().IsEmpty())
    {
      return string.Empty;
    }

    byte height = 0;

    switch (Size())
    {
      case PinterestPinItButtonSize.Large :
        switch (Shape())
        {
          case PinterestPinItButtonShape.Circular :
            height = 32;
            break;

          case PinterestPinItButtonShape.Rectangular :
            height = 28;
            break;
        }
        break;

      case PinterestPinItButtonSize.Small :
        switch (Shape())
        {
          case PinterestPinItButtonShape.Circular:
            height = 16;
            break;

          case PinterestPinItButtonShape.Rectangular:
            height = 20;
            break;
        }
        break;
    }

    var shape = string.Empty;
    switch (Shape())
    {
      case PinterestPinItButtonShape.Rectangular :
        shape = "rect";
        break;

      case PinterestPinItButtonShape.Circular :
        shape = "round";
        break;
    }

    return new TagBuilder("a")
      .Attribute("href", $"http://www.pinterest.com/pin/create/button/?url=${HttpUtility.UrlEncode(Url())}&media=${HttpUtility.UrlEncode(Image())}&description=${HttpUtility.UrlEncode(Description())}")
      .Attribute("data-pin-do", "buttonPin")
      .Attribute("data-pin-lang", Shape() == PinterestPinItButtonShape.Rectangular ? Language() : null)
      .Attribute("data-pin-config", Shape() == PinterestPinItButtonShape.Rectangular ? Counter().ToString().ToLowerInvariant() : null)
      .Attribute("data-pin-color", Shape() == PinterestPinItButtonShape.Rectangular ? Color() : null)
      .Attribute("data-pin-height", height)
      .Attribute("data-pin-shape", shape)
      .InnerHtml($@"<img src=""http://assets.pinterest.com/images/pidgets/pinit_fg_${Language()}_${shape}_${Color()}_${height}.png""/>")
      .ToString();
  }
}