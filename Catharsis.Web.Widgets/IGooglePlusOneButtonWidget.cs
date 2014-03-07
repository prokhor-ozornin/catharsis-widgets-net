using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Google "+1" button.</para>
  ///   <para>Requires <see cref="WidgetsScriptsBundles.Cackle"/> scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="https://developers.google.com/+/web/+1button/?hl=en"/>
  public interface IGooglePlusOneButtonWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>URL for the button. Default is current page's URL.</para>
    /// </summary>
    /// <param name="url">URL for the button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    IGooglePlusOneButtonWidget Url(string url);

    /// <summary>
    ///   <para>If annotation is set to "inline", this parameter sets the width in pixels to use for the button and its inline annotation. If the width is omitted, a button and its inline annotation use 450px.</para>
    /// </summary>
    /// <param name="width">Width of the button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    IGooglePlusOneButtonWidget Width(string width);

    /// <summary>
    ///   <para>Size of the button.</para>
    /// </summary>
    /// <param name="size">Size of the button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="size"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="size"/> is <see cref="string.Empty"/> string.</exception>
    IGooglePlusOneButtonWidget Size(string size);

    /// <summary>
    ///   <para>Horizontal alignment of the button assets within its frame.</para>
    /// </summary>
    /// <param name="alignment">Horizontal alignment of the button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="alignment"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="alignment"/> is <see cref="string.Empty"/> string.</exception>
    IGooglePlusOneButtonWidget Alignment(string alignment);

    /// <summary>
    ///   <para>Annotation to display next to the button.</para>
    /// </summary>
    /// <param name="annotation">Annotation for the button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="annotation"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="annotation"/> is <see cref="string.Empty"/> string.</exception>
    IGooglePlusOneButtonWidget Annotation(string annotation);

    /// <summary>
    ///   <para>Callback JavaScript function that is called after the user clicks the +1 button.</para>
    /// </summary>
    /// <param name="callback">Callback JavaScript function.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="callback"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="callback"/> is <see cref="string.Empty"/> string.</exception>
    IGooglePlusOneButtonWidget Callback(string callback);

    /// <summary>
    ///   <para>Whether to show recommendations within the +1 hover bubble. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="recommendations"><c>true</c> to show recommendations, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    IGooglePlusOneButtonWidget Recommendations(bool recommendations = true);
  }
}