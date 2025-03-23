namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYouTubeWidgetsCreator"/>
public class YouTubeWidgetsCreator : IYouTubeWidgetsCreator
{
  /// <inheritdoc cref="IYouTubeWidgetsCreator.Video()"/>
  public virtual IYouTubeVideoWidget Video() => new YouTubeVideoWidget();
}