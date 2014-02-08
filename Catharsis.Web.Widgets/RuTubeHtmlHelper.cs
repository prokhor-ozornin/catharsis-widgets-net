namespace Catharsis.Web.Widgets
{
  internal sealed class RuTubeHtmlHelper : IRuTubeHtmlHelper
  {
    public IRuTubeVideoWidget Video()
    {
      return new RuTubeVideoWidget();
    }

    public IRuTubeVideoLinkWidget VideoLink()
    {
      return new RuTubeVideoLinkWidget();
    }
  }
}