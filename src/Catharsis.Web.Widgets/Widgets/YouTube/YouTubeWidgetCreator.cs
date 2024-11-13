namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYouTubeWidgetCreator"/>
public class YouTubeWidgetCreator : IYouTubeWidgetCreator
{
  /// <inheritdoc cref="IYouTubeWidgetCreator.Video()"/>
  public IYouTubeVideoWidget Video() => new YouTubeVideoWidget();
}