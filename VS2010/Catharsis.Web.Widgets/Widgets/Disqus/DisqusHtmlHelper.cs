namespace Catharsis.Web.Widgets
{
  internal sealed class DisqusHtmlHelper : IDisqusHtmlHelper
  {
    public IDisqusCommentsWidget Comments()
    {
      return new DisqusCommentsWidget();
    }
  }
}