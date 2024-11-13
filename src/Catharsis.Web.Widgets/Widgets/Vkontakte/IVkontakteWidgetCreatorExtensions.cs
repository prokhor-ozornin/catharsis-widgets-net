namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IVkontakteWidgetCreator"/>.</para>
/// </summary>
/// <seealso cref="IVkontakteWidgetCreator"/>
public static class IVkontakteWidgetCreatorExtensions
{
  /// <summary>
  ///   <para>Creates new VKontakte OAuth button widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IVkontakteWidgetCreator.AuthButton()"/>
  public static string AuthButton(this IVkontakteWidgetCreator creator, Action<IVkontakteAuthButtonWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.AuthButton();

    builder(widget);
      
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new VKontakte JavaScript API initialization widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IVkontakteWidgetCreator.Initialize()"/>
  public static string Initialize(this IVkontakteWidgetCreator creator, Action<IVkontakteInitializationWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.Initialize();
      
    builder(widget);
      
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new VKontakte comments widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IVkontakteWidgetCreator.Comments()"/>
  public static string Comments(this IVkontakteWidgetCreator creator, Action<IVkontakteCommentsWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.Comments();
      
    builder(widget);
      
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new VKontakte community widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IVkontakteWidgetCreator.Community()"/>
  public static string Community(this IVkontakteWidgetCreator creator, Action<IVkontakteCommunityWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.Community();
      
    builder(widget);
      
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new VKontakte "Like" button widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IVkontakteWidgetCreator.LikeButton()"/>
  public static string LikeButton(this IVkontakteWidgetCreator creator, Action<IVkontakteLikeButtonWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.LikeButton();
      
    builder(widget);
      
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new VKontakte poll widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IVkontakteWidgetCreator.Poll()"/>
  public static string Poll(this IVkontakteWidgetCreator creator, Action<IVkontaktePollWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.Poll();
      
    builder(widget);
      
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new VKontakte embedded post widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IVkontakteWidgetCreator.Post()"/>
  public static string Post(this IVkontakteWidgetCreator creator, Action<IVkontaktePostWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.Post();
      
    builder(widget);
      
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new VKontakte Recommendations widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IVkontakteWidgetCreator.Recommendations()"/>
  public static string Recommendations(this IVkontakteWidgetCreator creator, Action<IVkontakteRecommendationsWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.Recommendations();
      
    builder(widget);
      
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new VKontakte subscription widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IVkontakteWidgetCreator.Subscription()"/>
  public static string Subscription(this IVkontakteWidgetCreator creator, Action<IVkontakteSubscriptionWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.Subscription();
      
    builder(widget);
      
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new VKontakte embedded video widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IVkontakteWidgetCreator.Video()"/>
  public static string Video(this IVkontakteWidgetCreator creator, Action<IVkontakteVideoWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.Video();
      
    builder(widget);
      
    return widget.ToHtml();
  }
}