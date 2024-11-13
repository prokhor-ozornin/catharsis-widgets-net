namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IAddThisWidgetsCreator"/>.</para>
/// </summary>
/// <seealso cref="IAddThisWidgetsCreator"/>
public static class IAddThisWidgetsCreatorExtensions
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="html"></param>
  /// <param name="builder"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IAddThisWidgetsCreator.SmartLayers()"/>
  public static string SmartLayers(this IAddThisWidgetsCreator html, Action<IAddThisSmartLayersWidget> builder)
  {
    if (html is null) throw new ArgumentNullException(nameof(html));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = html.SmartLayers();

    builder(widget);
    
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="html"></param>
  /// <param name="builder"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IAddThisWidgetsCreator.ShareButtons()"/>
  public static string ShareButtons(this IAddThisWidgetsCreator html, Action<IAddThisShareButtonsWidget> builder)
  {
    if (html is null) throw new ArgumentNullException(nameof(html));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = html.ShareButtons();

    builder(widget);
    
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="html"></param>
  /// <param name="builder"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IAddThisWidgetsCreator.FollowButtons()"/>
  public static string FollowButtons(this IAddThisWidgetsCreator html, Action<IAddThisFollowButtonsWidget> builder)
  {
    if (html is null) throw new ArgumentNullException(nameof(html));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = html.FollowButtons();

    builder(widget);
    
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="html"></param>
  /// <param name="builder"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IAddThisWidgetsCreator.WelcomeBar()"/>
  public static string WelcomeBar(this IAddThisWidgetsCreator html, Action<IAddThisWelcomeBarWidget> builder)
  {
    if (html is null) throw new ArgumentNullException(nameof(html));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = html.WelcomeBar();

    builder(widget);
    
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="html"></param>
  /// <param name="builder"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IAddThisWidgetsCreator.TrendingContent()"/>
  public static string TrendingContent(this IAddThisWidgetsCreator html, Action<IAddThisTrendingContentWidget> builder)
  {
    if (html is null) throw new ArgumentNullException(nameof(html));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = html.TrendingContent();

    builder(widget);
    
    return widget.ToHtml();
  }
}