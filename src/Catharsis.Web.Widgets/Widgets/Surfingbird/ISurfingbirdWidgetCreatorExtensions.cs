namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="ISurfingbirdWidgetCreator"/>.</para>
/// </summary>
/// <seealso cref="ISurfingbirdWidgetCreator"/>
public static class ISurfingbirdWidgetCreatorExtensions
{
  /// <summary>
  ///   <para>Creates new Surfingbird "Surf" button widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="ISurfingbirdWidgetCreator.SurfButton()"/>
  public static string SurfButton(this ISurfingbirdWidgetCreator creator, Action<ISurfingbirdSurfButtonWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.SurfButton();

    builder(widget);
      
    return widget.ToHtml();
  }
}