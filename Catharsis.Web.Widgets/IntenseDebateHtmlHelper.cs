namespace Catharsis.Web.Widgets
{
  internal class IntenseDebateHtmlHelper : IIntenseDebateHtmlHelper
  {
    public IIntenseDebateCommentsWidget Comments()
    {
      return new IntenseDebateCommentsWidget();
    }

    public IIntenseDebateLinkWidget Link()
    {
      return new IntenseDebateLinkWidget();
    }
  }
}