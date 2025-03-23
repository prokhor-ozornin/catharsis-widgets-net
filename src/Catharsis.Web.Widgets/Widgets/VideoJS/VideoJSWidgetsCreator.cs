namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVideoJSWidgetsCreator"/>
public class VideoJSWidgetsCreator : IVideoJSWidgetsCreator
{
  /// <inheritdoc cref="IVideoJSWidgetsCreator.Player()"/>
  public virtual IVideoJSPlayerWidget Player() => new VideoJSPlayerWidget();
}