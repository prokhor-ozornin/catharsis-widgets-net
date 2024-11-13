namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IVideoJSWidgetCreator"/>.</para>
/// </summary>
/// <seealso cref="IVideoJSWidgetCreator"/>
public static class IVideoJSWidgetCreatorExtensions
{
  /// <summary>
  ///   <para>Creates new VideoJS player widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IVideoJSWidgetCreator.Player()"/>
  public static string Player(this IVideoJSWidgetCreator creator, Action<IVideoJSPlayerWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.Player();

    builder(widget);
    
    return widget.ToHtml();
  }
}