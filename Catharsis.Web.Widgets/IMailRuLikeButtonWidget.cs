using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Mail.ru "Like" button on web page.</para>
  ///   <para>Requires <see cref="WidgetsScripts.MailRu"/> script to be included.</para>
  ///   <seealso cref="http://api.mail.ru/sites/plugins/share"/>
  /// </summary>
  public interface IMailRuLikeButtonWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Specifies type of button.</para>
    /// </summary>
    /// <param name="type">Type of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="type"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="type"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuLikeButtonWidget Type(string type);

    /// <summary>
    ///   <para>Specifies vertical size of button.</para>
    /// </summary>
    /// <param name="size">Vertical size of button.</param>
    /// <returns>Reference to the current widget.</returns>
    IMailRuLikeButtonWidget Size(string size);

    /// <summary>
    ///   <para>Specifies visual layout/appearance of button.</para>
    /// </summary>
    /// <param name="layout">Visual layout of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="layout"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="layout"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuLikeButtonWidget Layout(byte layout);

    /// <summary>
    ///   <para>Specifies whether to show text label on button. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="has"><c>true</c> to show text label, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    IMailRuLikeButtonWidget HasText(bool has = true);

    /// <summary>
    ///   <para>Specifies type of text label to show on button.</para>
    /// </summary>
    /// <param name="type">Type of text label.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="type"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="type"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuLikeButtonWidget TextType(byte type);

    /// <summary>
    ///   <para>Specifies whether to render share counter next to a button. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="has"><c>true</c> to show share counter, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    IMailRuLikeButtonWidget HasCounter(bool has = true);

    /// <summary>
    ///   <para>Specifies position of a share counter.</para>
    /// </summary>
    /// <param name="position">Position of a counter.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="position"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="position"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuLikeButtonWidget CounterPosition(string position);
  }
}