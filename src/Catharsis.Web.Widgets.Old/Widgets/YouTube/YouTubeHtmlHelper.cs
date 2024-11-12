namespace Catharsis.Web.Widgets
{
  internal sealed class YouTubeHtmlHelper : IYouTubeHtmlHelper
  {
    public IYouTubeVideoWidget Video() => new YouTubeVideoWidget();
  }
}