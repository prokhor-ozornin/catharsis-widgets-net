namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVideoJSWidgetCreator"/>
public class VideoJsWidgetCreator : IVideoJSWidgetCreator
{
  /// <inheritdoc cref="IVideoJSWidgetCreator.Player()"/>
  public IVideoJSPlayerWidget Player() => new VideoJSPlayerWidget();
}