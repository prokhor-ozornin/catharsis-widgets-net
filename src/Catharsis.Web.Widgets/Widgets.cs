namespace Catharsis.Web.Widgets;

/// <summary>
///   <para></para>
/// </summary>
public static class Widgets
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  public static IWebWidgetsCreator Web => new WebWidgetsCreator();

  /// <summary>
  ///   <para></para>
  /// </summary>
  private sealed class WebWidgetsCreator : IWebWidgetsCreator;
}