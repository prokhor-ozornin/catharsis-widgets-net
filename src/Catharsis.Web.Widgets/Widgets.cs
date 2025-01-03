namespace Catharsis.Web.Widgets;

/// <summary>
///   <para></para>
/// </summary>
public static class Widgets
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  public static IWebWidgetsCreator Create => new WebWidgetsCreator();
  
  /// <summary>
  ///   <para></para>
  /// </summary>
  public static IWidgetsScriptsRenderer Scripts => new WidgetsScriptsRenderer();

  /// <summary>
  ///   <para></para>
  /// </summary>
  public static IWidgetsStylesRenderer Styles => new WidgetsStylesRenderer();

  private sealed class WebWidgetsCreator : IWebWidgetsCreator;
  private sealed class WidgetsScriptsRenderer : IWidgetsScriptsRenderer;
  private sealed class WidgetsStylesRenderer : IWidgetsStylesRenderer;
}