namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="ITwitterWidgetCreator"/>.</para>
/// </summary>
/// <seealso cref="ITwitterWidgetCreator"/>
public static class ITwitterWidgetCreatorExtensions
{
  /// <summary>
  ///   <para>reates new Twitter "Follow" button widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="ITwitterWidgetCreator.FollowButton()"/>
  public static string FollowButton(this ITwitterWidgetCreator creator, Action<ITwitterFollowButtonWidget> builder)
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
  /// <seealso cref="ITwitterWidgetCreator.TweetButton()"/>
  public static string TweetButton(this ITwitterWidgetCreator creator, Action<ITwitterTweetButtonWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.TweetButton();

    builder(widget);
      
    return widget.ToHtml();
  }
}