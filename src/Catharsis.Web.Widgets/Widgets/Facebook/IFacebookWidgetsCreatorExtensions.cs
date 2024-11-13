namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IFacebookWidgetsCreator"/>.</para>
/// </summary>
/// <seealso cref="IFacebookWidgetsCreator"/>
public static class IFacebookWidgetsCreatorExtensions
{
  /// <summary>
  ///   <para>Creates new Facebook JavaScript API initialization widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookWidgetsCreator.Initialize()"/>
  public static string Initialize(this IFacebookWidgetsCreator creator, Action<IFacebookInitializationWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.Initialize();

    builder(widget);
    
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new Facebook Activity Feed widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookWidgetsCreator.ActivityFeed()"/>
  public static string ActivityFeed(this IFacebookWidgetsCreator creator, Action<IFacebookActivityFeedWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.ActivityFeed();
    
    builder(widget);
    
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new Facebook Recommendations Feed widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookWidgetsCreator.RecommendationsFeed()"/>
  public static string RecommendationsFeed(this IFacebookWidgetsCreator creator, Action<IFacebookRecommendationsFeedWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.RecommendationsFeed();
    
    builder(widget);
    
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new Facebook comments widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookWidgetsCreator.Comments()"/>
  public static string Comments(this IFacebookWidgetsCreator creator, Action<IFacebookCommentsWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.Comments();
    
    builder(widget);
    
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new Facebook Facepile widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookWidgetsCreator.Facepile()"/>
  public static string FacePile(this IFacebookWidgetsCreator creator, Action<IFacebookFacepileWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.Facepile();
    builder(widget);
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new Facebook "Follow" button widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookWidgetsCreator.Facepile()"/>
  public static string FollowButton(this IFacebookWidgetsCreator creator, Action<IFacebookFollowButtonWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.FollowButton();
    builder(widget);
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new Facebook "Like" button widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookWidgetsCreator.LikeButton()"/>
  public static string LikeButton(this IFacebookWidgetsCreator creator, Action<IFacebookLikeButtonWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.LikeButton();
    builder(widget);
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new Facebook Likebox widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookWidgetsCreator.LikeBox()"/>
  public static string LikeBox(this IFacebookWidgetsCreator creator, Action<IFacebookLikeBoxWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.LikeBox();
    builder(widget);
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new Facebook embedded post widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookWidgetsCreator.Post()"/>
  public static string Post(this IFacebookWidgetsCreator creator, Action<IFacebookPostWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.Post();
    builder(widget);
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new Facebook "Send" button widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookWidgetsCreator.SendButton()"/>
  public static string SendButton(this IFacebookWidgetsCreator creator, Action<IFacebookSendButtonWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.SendButton();
    builder(widget);
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new Facebook embedded video widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookWidgetsCreator.Video()"/>
  public static string Video(this IFacebookWidgetsCreator creator, Action<IFacebookVideoWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.Video();
    builder(widget);
    return widget.ToHtml();
  }
}