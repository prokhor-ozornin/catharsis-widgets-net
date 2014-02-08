using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Yandex "Like" button.</para>
  ///   <para>Requires <see cref="WidgetsScriptsBundles.Yandex"/> scripts bundle to be included.</para>
  /// </summary>
  public interface IYandexLikeButtonWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Specifies URL address of web page to share.</para>
    /// </summary>
    /// <param name="url">URL address of web page.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    IYandexLikeButtonWidget Url(string url);

    /// <summary>
    ///   <para>Specifies custom title text for shared page.</para>
    /// </summary>
    /// <param name="title">Title text.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="title"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="title"/> is <see cref="string.Empty"/> string.</exception>
    IYandexLikeButtonWidget Title(string title);

    /// <summary>
    ///   <para>Specifies size of the button.</para>
    /// </summary>
    /// <param name="size">Size of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="size"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="size"/> is <see cref="string.Empty"/> string.</exception>
    IYandexLikeButtonWidget Size(string size);

    /// <summary>
    ///   <para>Specifies visual layout/appearance of the button.</para>
    /// </summary>
    /// <param name="layout">Layout of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="layout"/> is <see cref="string.Empty"/> string.</exception>
    /// <exception cref="ArgumentException">If <paramref name="layout"/> is <see cref="string.Empty"/> string.</exception>
    IYandexLikeButtonWidget Layout(string layout);

    /// <summary>
    ///   <para>Specifies label text to draw on the button.</para>
    /// </summary>
    /// <param name="text">Label text.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="text"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="text"/> is <see cref="string.Empty"/> string.</exception>
    IYandexLikeButtonWidget Text(string text);
  }
}