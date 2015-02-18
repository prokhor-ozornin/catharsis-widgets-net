using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Mail.ru Faces (People On Site) widget.</para>
  ///   <para>Requires MailRu scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="http://api.mail.ru/sites/plugins/faces"/>
  /// <seealso cref="IWidgetsScriptsRendererExtensions.MailRu(IWidgetsScriptsRenderer)"/>
  public interface IMailRuFacesWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Color of Faces box background.</para>
    /// </summary>
    /// <param name="color">Background color.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuFacesWidget BackgroundColor(string color);

    /// <summary>
    ///   <para>Color of Faces box background.</para>
    /// </summary>
    /// <returns>Background color.</returns>
    string BackgroundColor();

    /// <summary>
    ///   <para>Color of Faces box border.</para>
    /// </summary>
    /// <param name="color">Border color.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuFacesWidget BorderColor(string color);

    /// <summary>
    ///   <para>Color of Faces box border.</para>
    /// </summary>
    /// <returns>Border color.</returns>
    string BorderColor();

    /// <summary>
    ///   <para>Domain of target site with which users have interacted.</para>
    /// </summary>
    /// <param name="domain">Target site domain.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="domain"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="domain"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IMailRuFacesWidget Domain(string domain);

    /// <summary>
    ///   <para>Domain of target site with which users have interacted.</para>
    /// </summary>
    /// <returns>Target site domain.</returns>
    string Domain();

    /// <summary>
    ///   <para>Name of font, used for text labels.</para>
    /// </summary>
    /// <param name="font">Font name.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="font"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="font"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuFacesWidget Font(string font);

    /// <summary>
    ///   <para>Name of font, used for text labels.</para>
    /// </summary>
    /// <returns>Font name.</returns>
    string Font();

    /// <summary>
    ///   <para>Height of Faces box area.</para>
    /// </summary>
    /// <param name="height">Area height.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IMailRuFacesWidget Height(string height);

    /// <summary>
    ///   <para>Height of Faces box area.</para>
    /// </summary>
    /// <returns>Area height.</returns>
    string Height();

    /// <summary>
    ///   <para>Color of Faces box hyperlinks.</para>
    /// </summary>
    /// <param name="color">Hyperlinks color.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuFacesWidget HyperlinkColor(string color);

    /// <summary>
    ///   <para>Color of Faces box hyperlinks.</para>
    /// </summary>
    /// <returns>Hyperlinks color.</returns>
    string HyperlinkColor();

    /// <summary>
    ///   <para>Color of Faces box text labels.</para>
    /// </summary>
    /// <param name="color">Text color.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuFacesWidget TextColor(string color);

    /// <summary>
    ///   <para>Color of Faces box text labels.</para>
    /// </summary>
    /// <returns>Text color.</returns>
    string TextColor();

    /// <summary>
    ///   <para>Whether to show or hide Faces box title.</para>
    /// </summary>
    /// <param name="show"><c>true</c> to show title, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    IMailRuFacesWidget Title(bool show);

    /// <summary>
    ///   <para>Whether to show or hide Faces box title.</para>
    /// </summary>
    /// <returns><c>true</c> to show title, <c>false</c> to hide.</returns>
    bool Title();

    /// <summary>
    ///   <para>Color of Faces box title.</para>
    /// </summary>
    /// <param name="color">Title color.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuFacesWidget TitleColor(string color);

    /// <summary>
    ///   <para>Color of Faces box title.</para>
    /// </summary>
    /// <returns>Title color.</returns>
    string TitleColor();

    /// <summary>
    ///   <para>Title text label of Faces box.</para>
    /// </summary>
    /// <param name="title">Title text.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="title"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="title"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuFacesWidget TitleText(string title);

    /// <summary>
    ///   <para>Title text label of Faces box.</para>
    /// </summary>
    /// <returns>Title text.</returns>
    string TitleText();

    /// <summary>
    ///   <para>Width of Faces box area.</para>
    /// </summary>
    /// <param name="width">Area width.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IMailRuFacesWidget Width(string width);

    /// <summary>
    ///   <para>Width of Faces box area.</para>
    /// </summary>
    /// <returns>Area width.</returns>
    string Width();
  }
}