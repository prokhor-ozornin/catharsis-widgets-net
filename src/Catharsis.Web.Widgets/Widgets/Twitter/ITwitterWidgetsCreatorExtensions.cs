namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="ITwitterWidgetsCreator"/>.</para>
/// </summary>
/// <seealso cref="ITwitterWidgetsCreator"/>
public static class ITwitterWidgetsCreatorExtensions
{
  /// <summary>
  ///   <para>reates new Twitter "Follow" button widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="ITwitterWidgetsCreator.FollowButton()"/>
  public static string FollowButton(this ITwitterWidgetsCreator creator, Action<ITwitterFollowButtonWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.FollowButton();

    builder(widget);
      
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new Twitter "Tweet" button widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="ITwitterWidgetsCreator.TweetButton()"/>
  public static string TweetButton(this ITwitterWidgetsCreator creator, Action<ITwitterTweetButtonWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.TweetButton();

    builder(widget);
      
    return widget.ToHtml();
  }
}