using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  public interface IMailRuFacesWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="color"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuFacesWidget BackgroundColor(string color);

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="domain"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="domain"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="domain"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IMailRuFacesWidget Domain(string domain);

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="font"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="font"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="font"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuFacesWidget Font(string font);

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="color"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuFacesWidget FrameColor(string color);

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="height"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuFacesWidget Height(string height);

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="color"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuFacesWidget HyperlinkColor(string color);

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="show"></param>
    /// <returns></returns>
    IMailRuFacesWidget ShowTitle(bool show = true);

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="color"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuFacesWidget TextColor(string color);

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="title"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="title"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="title"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuFacesWidget Title(string title);

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="color"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuFacesWidget TitleBackgroundColor(string color);

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="width"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuFacesWidget Width(string width);
  }
}