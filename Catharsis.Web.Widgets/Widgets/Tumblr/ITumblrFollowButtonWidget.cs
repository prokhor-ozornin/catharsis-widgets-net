using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Tumblr "Follow" button.</para>
  /// </summary>
  /// <seealso cref="http://www.tumblr.com/buttons"/>
  public interface ITumblrFollowButtonWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Name of Tumblr account (blog).</para>
    /// </summary>
    /// <param name="account">Name of blog.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    ITumblrFollowButtonWidget Account(string account);

    /// <summary>
    ///   <para>Name of Tumblr account (blog).</para>
    /// </summary>
    /// <returns>Name of blog.</returns>
    string Account();

    /// <summary>
    ///   <para>Visual color scheme of button.</para>
    /// </summary>
    /// <param name="scheme">Color scheme for button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="scheme"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="scheme"/> is <see cref="string.Empty"/> string.</exception>
    ITumblrFollowButtonWidget ColorScheme(string scheme);

    /// <summary>
    ///   <para>Visual color scheme of button.</para>
    /// </summary>
    /// <returns>Color scheme for button.</returns>
    string ColorScheme();

    /// <summary>
    ///   <para>Visual layout/appearance of button.</para>
    /// </summary>
    /// <param name="type">Layout of button.</param>
    /// <returns>Reference to the current widget.</returns>
    ITumblrFollowButtonWidget Type(byte type);

    /// <summary>
    ///   <para>Visual layout/appearance of button.</para>
    /// </summary>
    /// <returns>Layout of button.</returns>
    byte Type();
  }
}