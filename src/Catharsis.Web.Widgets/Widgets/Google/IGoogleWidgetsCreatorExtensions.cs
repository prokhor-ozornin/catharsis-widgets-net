namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IGoogleWidgetsCreator"/>.</para>
/// </summary>
/// <seealso cref="IGoogleWidgetsCreator"/>
public static class IGoogleWidgetsCreatorExtensions
{
  /// <summary>
  ///   <para>Creates new Google Analytics widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IGoogleWidgetsCreator.Analytics()"/>
  public static string Analytics(this IGoogleWidgetsCreator creator, Action<IGoogleAnalyticsWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.Analytics();

    builder(widget);
    
    return widget.ToHtml();
  }

  /// <summary>
  ///   <para>Creates new Google Map widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IGoogleWidgetsCreator.Map()"/>
  /*public static string Map(this IGoogleWidgetsCreator creator, Action<IGoogleMapWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.Map();
    builder(widget);
    return widget.ToHtml();
  }*/

  /// <summary>
  ///   <para>Creates new Google "+1" button widget.</para>
  /// </summary>
  /// <param name="creator">Helper object to call method on.</param>
  /// <param name="builder">Delegate that performs configuration of the widget.</param>
  /// <returns>HTML contents of configured and rendered widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="creator"/> or <paramref name="builder"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IGoogleWidgetsCreator.PlusOneButton()"/>
  public static string PlusOneButton(this IGoogleWidgetsCreator creator, Action<IGooglePlusOneButtonWidget> builder)
  {
    if (creator is null) throw new ArgumentNullException(nameof(creator));
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    var widget = creator.PlusOneButton();
    
    builder(widget);
    
    return widget.ToHtml();
  }
}