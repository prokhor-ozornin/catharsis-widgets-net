using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Mail.ru "Like" button on web page.</para>
  ///   <para>Requires MailRu scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="http://api.mail.ru/sites/plugins/share"/>
  /// <seealso cref="IWidgetsScriptsRendererExtensions.MailRu(IWidgetsScriptsRenderer)"/>
  public interface IMailRuLikeButtonWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Whether to render share counter next to a button. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="show"><c>true</c> to show share counter, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    IMailRuLikeButtonWidget Counter(bool show);

    /// <summary>
    ///   <para>Whether to render share counter next to a button. Default is <c>true</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to show share counter, <c>false</c> to hide.</returns>
    bool Counter();

    /// <summary>
    ///   <para>Position of a share counter.</para>
    /// </summary>
    /// <param name="position">Position of a counter.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="position"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="position"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuLikeButtonWidget CounterPosition(string position);

    /// <summary>
    ///   <para>Position of a share counter.</para>
    /// </summary>
    /// <returns>Position of a counter.</returns>
    string CounterPosition();

    /// <summary>
    ///   <para>Visual layout/appearance of button.</para>
    /// </summary>
    /// <param name="layout">Visual layout of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="layout"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="layout"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuLikeButtonWidget Layout(byte layout);

    /// <summary>
    ///   <para>Visual layout/appearance of button.</para>
    /// </summary>
    /// <returns>Visual layout of button.</returns>
    byte Layout();

    /// <summary>
    ///   <para>Vertical size of button.</para>
    /// </summary>
    /// <param name="size">Vertical size of button.</param>
    /// <returns>Reference to the current widget.</returns>
    IMailRuLikeButtonWidget Size(string size);

    /// <summary>
    ///   <para>Vertical size of button.</para>
    /// </summary>
    /// <returns>Vertical size of button.</returns>
    string Size();

    /// <summary>
    ///   <para>Whether to show text label on button. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="text"><c>true</c> to show text label, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    IMailRuLikeButtonWidget Text(bool text);

    /// <summary>
    ///   <para>Whether to show text label on button. Default is <c>true</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to show text label, <c>false</c> to hide.</returns>
    bool Text();

    /// <summary>
    ///   <para>Type of text label to show on button.</para>
    /// </summary>
    /// <param name="type">Type of text label.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="type"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="type"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuLikeButtonWidget TextType(byte type);

    /// <summary>
    ///   <para>Type of text label to show on button.</para>
    /// </summary>
    /// <returns>Type of text label.</returns>
    byte TextType();

    /// <summary>
    ///   <para>Type of button.</para>
    /// </summary>
    /// <param name="type">Type of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="type"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="type"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuLikeButtonWidget Type(string type);

    /// <summary>
    ///   <para>Type of button.</para>
    /// </summary>
    /// <returns>Type of button.</returns>
    string Type();
  }
}