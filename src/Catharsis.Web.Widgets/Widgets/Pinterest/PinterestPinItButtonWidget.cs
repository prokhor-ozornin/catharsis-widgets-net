using System;
using System.Web;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Pinterest "Pin It" button widget.</para>
  ///   <para>Requires Pinterest scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="http://business.pinterest.com/widget-builder/#do_pin_it_button"/>
  /// <seealso cref="IWidgetsScriptsRendererExtensions.Pinterest(IWidgetsScriptsRenderer)"/>
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
      Assertion.NotEmpty(color);

      this.color = color;
      return this;
    }

    /// <summary>
    ///   <para>Background color of the button.</para>
    /// </summary>
    /// <returns>Button's color.</returns>
    public string Color()
    {
      return this.color;
    }

    /// <summary>
    ///   <para>Position of button's pin counter.</para>
    /// </summary>
    /// <param name="position">Pin counter's position.</param>
    /// <returns>Reference to the current widget.</returns>
    public IPinterestPinItButtonWidget Counter(PinterestPinItButtonPinCountPosition position)
    {
      this.counter = position;

      return this;
    }

    /// <summary>
    ///   <para>Position of button's pin counter.</para>
    /// </summary>
    /// <returns>Pin counter's position.</returns>
    public PinterestPinItButtonPinCountPosition Counter()
    {
      return this.counter;
    }

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
      Assertion.NotEmpty(description);

      this.description = description;
      return this;
    }

    /// <summary>
    ///   <para>Description of the "pinned" image.</para>
    /// </summary>
    /// <returns>Pin's description.</returns>
    public string Description()
    {
      return this.description;
    }

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
      Assertion.NotEmpty(url);

      this.image = url;
      return this;
    }

    /// <summary>
    ///   <para>URL address of the "pinned" image.</para>
    /// </summary>
    /// <returns>Pin's image URL.</returns>
    public string Image()
    {
      return this.image;
    }

    /// <summary>
    ///   <para>Language of button's label.</para>
    /// </summary>
    /// <param name="language">Button's text language.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="language"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="language"/> is <see cref="string.Empty"/> string.</exception>
    public IPinterestPinItButtonWidget Language(string language)
    {
      Assertion.NotEmpty(language);

      this.language = language;
      return this;
    }

    /// <summary>
    ///   <para>Language of button's label.</para>
    /// </summary>
    /// <returns>Button's text language.</returns>
    public string Language()
    {
      return this.language;
    }

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
    public PinterestPinItButtonShape Shape()
    {
      return this.shape;
    }

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
    public PinterestPinItButtonSize Size()
    {
      return this.size;
    }

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
      Assertion.NotEmpty(url);

      this.url = url;
      return this;
    }

    /// <summary>
    ///   <para>URL address of target web page for the button.</para>
    /// </summary>
    /// <returns>Button's target web page.</returns>
    public string Url()
    {
      return this.url;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (this.Url().IsEmpty() || this.Image().IsEmpty() || this.Description().IsEmpty())
      {
        return string.Empty;
      }

      byte height = 0;
      switch (this.Size())
      {
        case PinterestPinItButtonSize.Large :
          switch (this.Shape())
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
          switch (this.Shape())
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

      string shape = string.Empty;
      switch (this.Shape())
      {
        case PinterestPinItButtonShape.Rectangular :
          shape = "rect";
        break;

        case PinterestPinItButtonShape.Circular :
          shape = "round";
        break;
      }

      return new TagBuilder("a")
        .Attribute("href", "http://www.pinterest.com/pin/create/button/?url={0}&media={1}&description={2}".FormatSelf(HttpUtility.UrlEncode(this.Url()), HttpUtility.UrlEncode(this.Image()), HttpUtility.UrlEncode(this.Description())))
        .Attribute("data-pin-do", "buttonPin")
        .Attribute("data-pin-lang", this.Shape() == PinterestPinItButtonShape.Rectangular ? this.Language() : null)
        .Attribute("data-pin-config", this.Shape() == PinterestPinItButtonShape.Rectangular ? this.Counter().ToString().ToLowerInvariant() : null)
        .Attribute("data-pin-color", this.Shape() == PinterestPinItButtonShape.Rectangular ? this.Color() : null)
        .Attribute("data-pin-height", height)
        .Attribute("data-pin-shape", shape)
        .InnerHtml(@"<img src=""http://assets.pinterest.com/images/pidgets/pinit_fg_{0}_{1}_{2}_{3}.png""/>".FormatSelf(this.Language(), shape, this.Color(), height))
        .ToString();
    }
  }
}