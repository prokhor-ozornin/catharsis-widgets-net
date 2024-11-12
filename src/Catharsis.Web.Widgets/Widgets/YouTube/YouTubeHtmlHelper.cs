namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYouTubeHtmlHelper"/>
public class YouTubeHtmlHelper : IYouTubeHtmlHelper
{
  /// <inheritdoc cref="IYouTubeHtmlHelper.Video()"/>
  public IYouTubeVideoWidget Video() => new YouTubeVideoWidget();
}