namespace Catharsis.Web.Widgets
{
  internal sealed class VideoJSHtmlHelper : IVideoJSHtmlHelper
  {
    public IVideoJSPlayerWidget Player()
    {
      return new VideoJSPlayerWidget();
    }
  }
}