namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Scripts bundles manager to render JavaScript <c>script</c> tags, required by different categories of widgets.</para>
  /// </summary>
  public sealed class WebWidgetsScripts
  {
    private static readonly IWidgetsScriptsRenderer renderer = new WidgetsJavaScriptRenderer();

    /// <summary>
    ///   <para>Returns JavaScript code renderer.</para>
    /// </summary>
    /// <returns>JavaScript renderer.</returns>
    public static IWidgetsScriptsRenderer Render()
    {
      return renderer;
    }

    private WebWidgetsScripts()
    {
    }

    private sealed class WidgetsJavaScriptRenderer : IWidgetsScriptsRenderer
    {
    }
  }
}