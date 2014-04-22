namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Styles bundles manager to render CSS <c>link</c> or <c>style</c> tags, required by different categories of widgets.</para>
  /// </summary>
  public sealed class WebWidgetsStyles
  {
    private static readonly IWidgetsStylesRenderer renderer = new WidgetsCssRenderer();

    /// <summary>
    ///   <para>Returns CSS code renderer.</para>
    /// </summary>
    /// <returns>CSS renderer.</returns>
    public static IWidgetsStylesRenderer Render()
    {
      return renderer;
    }

    private WebWidgetsStyles()
    {
    }

    private sealed class WidgetsCssRenderer : IWidgetsStylesRenderer
    {
    }
  }
}