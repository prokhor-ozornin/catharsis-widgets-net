using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders VKontakte "Like" button widget.</para>
  ///   <para>Requires Vkontakte JavaScript initialization to be performed first.</para>
  /// </summary>
  /// <seealso cref="http://vk.com/dev/Like"/>
  public interface IVkontakteLikeButtonWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Vertical height of the button in pixels. Default value is "22".</para>
    /// </summary>
    /// <param name="height">Height of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
    IVkontakteLikeButtonWidget Height(string height);

    /// <summary>
    ///   <para>Vertical height of the button in pixels. Default value is "22".</para>
    /// </summary>
    /// <returns>Height of button.</returns>
    string Height();

    /// <summary>
    ///   <para>Visual layout/appearance of the button.</para>
    /// </summary>
    /// <param name="layout">Layout of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="layout"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="layout"/> is <see cref="string.Empty"/> string.</exception>
    IVkontakteLikeButtonWidget Layout(string layout);

    /// <summary>
    ///   <para>Visual layout/appearance of the button.</para>
    /// </summary>
    /// <returns>Layout of button.</returns>
    string Layout();

    /// <summary>
    ///   <para>Description of the page (to display in preview mode for record on the wall).</para>
    /// </summary>
    /// <param name="description">Description of the page.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="description"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="description"/> is <see cref="string.Empty"/> string.</exception>
    IVkontakteLikeButtonWidget Description(string description);

    /// <summary>
    ///   <para>Description of the page (to display in preview mode for record on the wall).</para>
    /// </summary>
    /// <returns>Description of the page.</returns>
    string Description();

    /// <summary>
    ///   <para>URL of the thumbnail image (to display in preview mode for record on the wall).</para>
    /// </summary>
    /// <param name="url">URL of post's thumbnail image.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    IVkontakteLikeButtonWidget Image(string url);

    /// <summary>
    ///   <para>URL of the thumbnail image (to display in preview mode for record on the wall).</para>
    /// </summary>
    /// <returns>URL of post's thumbnail image.</returns>
    string Image();

    /// <summary>
    ///   <para>Title of the page (to display in preview mode for record on the wall).</para>
    /// </summary>
    /// <param name="title">Title of the page.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="title"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="title"/> is <see cref="string.Empty"/> string.</exception>
    IVkontakteLikeButtonWidget Title(string title);

    /// <summary>
    ///   <para>Title of the page (to display in preview mode for record on the wall).</para>
    /// </summary>
    /// <returns>Title of the page.</returns>
    string Title();

    /// <summary>
    ///   <para>URL of the page to "like" (this URL will be shown in a record on the wall). Default is URL of the current page.</para>
    /// </summary>
    /// <param name="url">URL of target web page.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    IVkontakteLikeButtonWidget Url(string url);

    /// <summary>
    ///   <para>URL of the page to "like" (this URL will be shown in a record on the wall). Default is URL of the current page.</para>
    /// </summary>
    /// <returns>URL of target web page.</returns>
    string Url();

    /// <summary>
    ///   <para>Text to be published on the wall when "Tell to friends" is pressed. Maximum length is 140 characters. Default value equals to page's title.</para>
    /// </summary>
    /// <param name="text">Text for publishing.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="text"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="text"/> is <see cref="string.Empty"/> string.</exception>
    IVkontakteLikeButtonWidget Text(string text);

    /// <summary>
    ///   <para>Text to be published on the wall when "Tell to friends" is pressed. Maximum length is 140 characters. Default value equals to page's title.</para>
    /// </summary>
    /// <returns>Text for publishing.</returns>
    string Text();

    /// <summary>
    ///   <para>Type of text to display on the button.</para>
    /// </summary>
    /// <param name="verb">Displayed button's verb.</param>
    /// <returns>Reference to the current widget.</returns>
    IVkontakteLikeButtonWidget Verb(byte verb);

    /// <summary>
    ///   <para>Type of text to display on the button.</para>
    /// </summary>
    /// <returns>Displayed button's verb.</returns>
    byte? Verb();

    /// <summary>
    ///   <para>Width of button in pixels (integer value > 200, default value is 350). Parameter value has meaning only for a button with a text counter (layout = "full").</para>
    /// </summary>
    /// <param name="width">Width of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    IVkontakteLikeButtonWidget Width(string width);

    /// <summary>
    ///   <para>Width of button in pixels (integer value > 200, default value is 350). Parameter value has meaning only for a button with a text counter (layout = "full").</para>
    /// </summary>
    /// <returns>Width of button.</returns>
    string Width();
  }
}