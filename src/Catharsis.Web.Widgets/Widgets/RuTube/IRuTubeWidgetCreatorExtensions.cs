namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IRuTubeWidgetCreator"/>.</para>
/// </summary>
/// <seealso cref="IRuTubeWidgetCreator"/>
public static class IRuTubeWidgetCreatorExtensions
{
  /// <summary>
  ///   <para>Creates new RuTube embedded video widget.</para>
  /// </summary>
  /// <param name="html">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="html"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IRuTubeWidgetCreator.Video()"/>
  public static string Video(this IRuTubeWidgetCreator html, Action<IRuTubeVideoWidget> builder)
  {
    if (html is null) throw new ArgumentNullException(nameof(html));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = html.Video();

    builder(widget);
      
    return widget.ToHtml();
  }
}