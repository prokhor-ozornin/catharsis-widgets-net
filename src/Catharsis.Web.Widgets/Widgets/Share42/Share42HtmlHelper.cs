namespace Catharsis.Web.Widgets
{
  internal sealed class Share42HtmlHelper : IShare42HtmlHelper
  {
    public IShare42PanelWidget Panel()
    {
      return new Share42PanelWidget();
    }
  }
}