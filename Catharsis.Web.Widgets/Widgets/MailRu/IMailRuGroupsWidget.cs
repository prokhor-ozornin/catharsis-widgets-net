using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Mail.ru Group (People In Group) widget.</para>
  ///   <para>Requires MailRu scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="http://api.mail.ru/sites/plugins/groups"/>
  /// <seealso cref="IWidgetsScriptsRendererExtensions.MailRu(IWidgetsScriptsRenderer)"/>
  public interface IMailRuGroupsWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Account name of Mail.ru group.</para>
    /// </summary>
    /// <param name="account">Group name.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IMailRuGroupsWidget Account(string account);

    /// <summary>
    ///   <para>Color of Groups box background.</para>
    /// </summary>
    /// <param name="color">Background color.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuGroupsWidget BackgroundColor(string color);

    /// <summary>
    ///   <para>Color of "Subscribe" button in Groups box.</para>
    /// </summary>
    /// <param name="color">Button color.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuGroupsWidget ButtonColor(string color);

    /// <summary>
    ///   <para>Target site domain.</para>
    /// </summary>
    /// <param name="domain">Target domain.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="domain"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="domain"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuGroupsWidget Domain(string domain);

    /// <summary>
    ///   <para>Height of Groups box area.</para>
    /// </summary>
    /// <param name="height">Area height.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuGroupsWidget Height(string height);

    /// <summary>
    ///   <para>Whether to show portraits of group's subscribers or not.</para>
    /// </summary>
    /// <param name="show"><c>true</c> to show subscribers, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    IMailRuGroupsWidget Subscribers(bool show = true);

    /// <summary>
    ///   <para>Color of Groups box text labels.</para>
    /// </summary>
    /// <param name="color">Text color.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuGroupsWidget TextColor(string color);

    /// <summary>
    ///   <para>Width of Groups box area.</para>
    /// </summary>
    /// <param name="width">Area width.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuGroupsWidget Width(string width);
  }
}