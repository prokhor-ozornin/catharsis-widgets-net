namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IRuTubeWidgetsCreator"/>.</para>
/// </summary>
/// <seealso cref="IRuTubeWidgetsCreator"/>
public static class IRuTubeWidgetsCreatorExtensions
{
  /// <summary>
  ///   <para>Creates new RuTube embedded video widget.</para>
  /// </summary>
  /// <param name="html">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IRuTubeWidgetsCreator.Video()"/>
  public static string Video(this IRuTubeWidgetsCreator html, Action<IRuTubeVideoWidget> builder)
  {
    if (html is null) throw new ArgumentNullException(nameof(html));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = html.Video();

    builder(widget);
      
    return widget.ToHtml();
  }
}