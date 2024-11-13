namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for itnerface <see cref="IYouTubeWidgetCreator"/>.</para>
/// </summary>
/// <seealso cref="IYouTubeWidgetCreator"/>
public static class IYouTubeWidgetCreatorExtensions
{
  /// <summary>
  ///   <para>Creates new YouTube embedded video widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IYouTubeWidgetCreator.Video()"/>
  public static string Video(this IYouTubeWidgetCreator creator, Action<IYouTubeVideoWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.Video();

    builder(widget);
      
    return widget.ToHtml();
  }
}