namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IVimeoWidgetsCreator"/>.</para>
/// </summary>
/// <seealso cref="IVimeoWidgetsCreator"/>
public static class IVimeoWidgetsCreatorExtensions
{
  /// <summary>
  ///   <para>Creates new Vimeo embedded video widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IVimeoWidgetsCreator.Video()"/>
  public static string Video(this IVimeoWidgetsCreator creator, Action<IVimeoVideoWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.Video();

    builder(widget);
      
    return widget.ToHtml();
  }
}