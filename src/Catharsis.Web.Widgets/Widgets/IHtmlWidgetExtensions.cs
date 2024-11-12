namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IHtmlWidget"/>.</para>
/// </summary>
/// <seealso cref="IHtmlWidget"/>
public static class IHtmlWidgetExtensions
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="widget"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  public static T Render<T>(this T widget) where T : IHtmlWidget
  {
    if (widget is null) throw new ArgumentNullException(nameof(widget));

    if (HttpContext.Current is not null)
    {
      HttpContext.Current.Response.Output.Write(widget.ToHtmlString());
    }

    return widget;
  }
}