using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Surfingbird "Surf" button.</para>
  ///   <para>Requires <see cref="WidgetsScripts.SurfingbirdSurf"/> script to be included.</para>
  ///   <seealso cref="http://surfingbird.ru/publishers/surfbutton"/>
  /// </summary>
  public interface ISurfingbirdSurfButtonWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Specifies URL address of web page to "like". Default is current web page.</para>
    /// </summary>
    /// <param name="url">URL of web page.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    ISurfingbirdSurfButtonWidget Url(string url);

    /// <summary>
    ///   <para>Layout/appearance of the button.</para>
    /// </summary>
    /// <param name="layout">Layout of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="layout"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="layout"/> is <see cref="string.Empty"/> string.</exception>
    ISurfingbirdSurfButtonWidget Layout(string layout);

    /// <summary>
    ///   <para>Horizontal width of the button. Default is 500px.</para>
    /// </summary>
    /// <param name="width">Width of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    ISurfingbirdSurfButtonWidget Width(string width);

    /// <summary>
    ///   <para>Vertical height of the button. Default is 25px.</para>
    /// </summary>
    /// <param name="height">Height of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
    ISurfingbirdSurfButtonWidget Height(string height);

    /// <summary>
    ///   <para>Whether to render share counter next to a button. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="counter"><c>true</c> to show counter, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    ISurfingbirdSurfButtonWidget Counter(bool counter = true);

    /// <summary>
    ///   <para>Text label to show on button. Default is "Surf".</para>
    /// </summary>
    /// <param name="label">Text label on button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="label"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="label"/> is <see cref="string.Empty"/> string.</exception>
    ISurfingbirdSurfButtonWidget Label(string label);

    /// <summary>
    ///   <para>Text label's color. If not specified, default color combination is used.</para>
    /// </summary>
    /// <param name="color">Label's color.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    ISurfingbirdSurfButtonWidget Color(string color);
  }
}