namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IShare42WidgetCreator"/>.</para>
///   <seealso cref="IShare42WidgetCreator"/>
/// </summary>
public static class IShare42WidgetCreatorExtensions
{
  /// <summary>
  ///   <para>Creates nwe Share42 Panel widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IShare42WidgetCreator.Panel()"/>
  public static string Panel(this IShare42WidgetCreator creator, Action<IShare42PanelWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.Panel();

    builder(widget);
    
    return widget.ToHtml();
  }
}