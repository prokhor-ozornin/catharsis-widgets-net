namespace Catharsis.Web.Widgets
{
  internal sealed class RuTubeHtmlHelper : IRuTubeHtmlHelper
  {
    public IRuTubeVideoWidget Video() => new RuTubeVideoWidget();
  }
}