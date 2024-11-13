namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IPinterestWidgetCreator"/>.</para>
/// </summary>
/// <seealso cref="IPinterestWidgetCreator"/>
public static class IPinterestWidgetCreatorExtensions
{
  /// <summary>
  ///   <para>Creates new Pinterest Board widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IPinterestWidgetCreator.Board()"/>
  public static string Board(this IPinterestWidgetCreator creator, Action<IPinterestBoardWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.Board();

    builder(widget);
      
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new Pinterest "Follow Me" button widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IPinterestWidgetCreator.FollowButton()"/>
  public static string FollowButton(this IPinterestWidgetCreator creator, Action<IPinterestFollowButtonWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.FollowButton();

    builder(widget);
      
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new Pinterest "Pin It" button widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IPinterestWidgetCreator.PinItButton()"/>
  public static string PinItButton(this IPinterestWidgetCreator creator, Action<IPinterestPinItButtonWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.PinItButton();

    builder(widget);
      
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new Pinterest embedded pin widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IPinterestWidgetCreator.Pin()"/>
  public static string Pin(this IPinterestWidgetCreator creator, Action<IPinterestPinWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.Pin();

    builder(widget);
      
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new Pinterest Profile widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IPinterestWidgetCreator.Profile()"/>
  public static string Profile(this IPinterestWidgetCreator creator, Action<IPinterestProfileWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.Profile();

    builder(widget);
      
    return widget.ToHtml();
  }
}