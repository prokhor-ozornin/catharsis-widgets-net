using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  public interface IMailRuGroupsWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="domain"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="domain"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="domain"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IMailRuGroupsWidget Account(string domain);

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="color"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuGroupsWidget BackgroundColor(string color);

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="color"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuGroupsWidget ButtonColor(string color);

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="domain"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="domain"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="domain"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IMailRuGroupsWidget Domain(string domain);

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="height"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuGroupsWidget Height(string height);

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="show"></param>
    /// <returns></returns>
    IMailRuGroupsWidget Subscribers(bool show = true);

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="color"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuGroupsWidget TextColor(string color);

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="width"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuGroupsWidget Width(string width);
  }
}