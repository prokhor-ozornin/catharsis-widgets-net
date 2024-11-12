namespace Catharsis.Web.Widgets
{
  internal class IntenseDebateHtmlHelper : IIntenseDebateHtmlHelper
  {
    public IIntenseDebateCommentsWidget Comments() => new IntenseDebateCommentsWidget();

    public IIntenseDebateLinkWidget Link() => new IntenseDebateLinkWidget();
  }
}