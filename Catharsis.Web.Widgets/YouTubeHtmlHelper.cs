namespace Catharsis.Web.Widgets
{
  internal sealed class YouTubeHtmlHelper : IYouTubeHtmlHelper
  {
    public IYouTubeVideoWidget Video()
    {
      return new YouTubeVideoWidget();
    }

    public IYouTubeVideoLinkWidget VideoLink()
    {
      return new YouTubeVideoLinkWidget();
    }
  }
}