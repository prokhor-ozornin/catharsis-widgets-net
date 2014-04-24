using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Cackle latest comments widget for registered website.</para>
  ///   <para>Requires Cackle scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="http://ru.cackle.me/help/widget-api"/>
  /// <seealso cref="IWidgetsScriptsRendererExtensions.Cackle(IWidgetsScriptsRenderer)"/>
  public interface ICackleLatestCommentsWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Identifier of registered website in the "Cackle" comments system.</para>
    /// </summary>
    /// <param name="account">Identifier of website.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    ICackleLatestCommentsWidget Account(string account);

    /// <summary>
    ///   <para>Size of user avatars. Default is 32.</para>
    /// </summary>
    /// <param name="size">Size of user avatars.</param>
    /// <returns>Reference to the current widget.</returns>
    ICackleLatestCommentsWidget AvatarSize(short size);

    /// <summary>
    ///   <para>Number of comments to display. Maximum 100, default 5.</para>
    /// </summary>
    /// <param name="max">Number of comments to display.</param>
    /// <returns>Reference to the current widget.</returns>
    ICackleLatestCommentsWidget Max(byte max);

    /// <summary>
    ///   <para>Maximum allowed count of characters in comment (0 - do not cut). Default is 150.</para>
    /// </summary>
    /// <param name="size">Maximum count of characters in comment.</param>
    /// <returns>Reference to the current widget.</returns>
    ICackleLatestCommentsWidget TextSize(int size);

    /// <summary>
    ///   <para>Maximum allowed count of characters in title (0 - do not cut). Default is 40.</para>
    /// </summary>
    /// <param name="size">Maximum count of characters in title.</param>
    /// <returns>Reference to the current widget.</returns>
    ICackleLatestCommentsWidget TitleSize(int size);
  }
}