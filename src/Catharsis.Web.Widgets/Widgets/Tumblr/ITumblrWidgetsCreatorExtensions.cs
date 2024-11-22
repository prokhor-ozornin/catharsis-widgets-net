namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="ITumblrWidgetsCreator"/>.</para>
/// </summary>
/// <seealso cref="ITumblrWidgetsCreator"/>
public static class ITumblrWidgetsCreatorExtensions
{
  /// <summary>
  ///   <para>Creates new Tumblr "Follow" button widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="ITumblrWidgetsCreator.FollowButton()"/>
  public static string FollowButton(this ITumblrWidgetsCreator creator, Action<ITumblrFollowButtonWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.FollowButton();

    builder(widget);
      
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new Tumblr "Share" button widget.</para>
  /// </summary>
  /// <param name="html">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="ITumblrWidgetsCreator.ShareButton()"/>
  public static string ShareButton(this ITumblrWidgetsCreator html, Action<ITumblrShareButtonWidget> builder)
  {
    if (html is null) throw new ArgumentNullException(nameof(html));
    if (builder is null) throw new ArgumentNullException(nameof(builder));
      
    var widget = html.ShareButton();

    builder(widget);
      
    return widget.ToHtml();
  }
}