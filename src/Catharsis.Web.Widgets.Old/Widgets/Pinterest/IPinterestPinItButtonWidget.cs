using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Pinterest "Pin It" button widget.</para>
  ///   <para>Requires Pinterest scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="http://business.pinterest.com/widget-builder/#do_pin_it_button"/>
  /// <seealso cref="IWidgetsScriptsRendererExtensions.Pinterest(IWidgetsScriptsRenderer)"/>
  public interface IPinterestPinItButtonWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Background color of the button.</para>
    /// </summary>
    /// <param name="color">Button's color.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    IPinterestPinItButtonWidget Color(string color);

    /// <summary>
    ///   <para>Background color of the button.</para>
    /// </summary>
    /// <returns>Button's color.</returns>
    string Color();

    /// <summary>
    ///   <para>Position of button's pin counter.</para>
    /// </summary>
    /// <param name="position">Pin counter's position.</param>
    /// <returns>Reference to the current widget.</returns>
    IPinterestPinItButtonWidget Counter(PinterestPinItButtonPinCountPosition position);

    /// <summary>
    ///   <para>Position of button's pin counter.</para>
    /// </summary>
    /// <returns>Pin counter's position.</returns>
    PinterestPinItButtonPinCountPosition Counter();

    /// <summary>
    ///   <para>Description of the "pinned" image.</para>
    /// </summary>
    /// <param name="description">Pin's description.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="description"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="description"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IPinterestPinItButtonWidget Description(string description);

    /// <summary>
    ///   <para>Description of the "pinned" image.</para>
    /// </summary>
    /// <returns>Pin's description.</returns>
    string Description();

    /// <summary>
    ///   <para>URL address of the "pinned" image.</para>
    /// </summary>
    /// <param name="url">Pin's image URL.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IPinterestPinItButtonWidget Image(string url);

    /// <summary>
    ///   <para>URL address of the "pinned" image.</para>
    /// </summary>
    /// <returns>Pin's image URL.</returns>
    string Image();
    
    /// <summary>
    ///   <para>Language of button's label.</para>
    /// </summary>
    /// <param name="language">Button's text language.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="language"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="language"/> is <see cref="string.Empty"/> string.</exception>
    IPinterestPinItButtonWidget Language(string language);

    /// <summary>
    ///   <para>Language of button's label.</para>
    /// </summary>
    /// <returns>Button's text language.</returns>
    string Language();

    /// <summary>
    ///   <para>Shape of the button.</para>
    /// </summary>
    /// <param name="shape">Button's shape.</param>
    /// <returns>Reference to the current widget.</returns>
    IPinterestPinItButtonWidget Shape(PinterestPinItButtonShape shape);

    /// <summary>
    ///   <para>Shape of the button.</para>
    /// </summary>
    /// <returns>Button's shape.</returns>
    PinterestPinItButtonShape Shape();

    /// <summary>
    ///   <para>Size of the button.</para>
    /// </summary>
    /// <param name="size">Button's size.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <remarks>Actual vertical size in pixels also depends on the button's shape.</remarks>
    IPinterestPinItButtonWidget Size(PinterestPinItButtonSize size);

    /// <summary>
    ///   <para>Size of the button.</para>
    /// </summary>
    /// <returns>Button's size.</returns>
    PinterestPinItButtonSize Size();

    /// <summary>
    ///   <para>URL address of target web page for the button.</para>
    /// </summary>
    /// <param name="url">Button's target web page.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IPinterestPinItButtonWidget Url(string url);

    /// <summary>
    ///   <para>URL address of target web page for the button.</para>
    /// </summary>
    /// <returns>Button's target web page.</returns>
    string Url();
  }
}