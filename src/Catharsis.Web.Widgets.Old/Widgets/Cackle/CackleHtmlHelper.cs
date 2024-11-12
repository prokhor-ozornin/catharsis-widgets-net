namespace Catharsis.Web.Widgets
{
  internal sealed class CackleHtmlHelper : ICackleHtmlHelper
  {
    public ICackleCommentsWidget Comments() => new CackleCommentsWidget();

    public ICackleCommentsCountWidget CommentsCount() => new CackleCommentsCountWidget();

    public ICackleLatestCommentsWidget LatestComments() => new CackleLatestCommentsWidget();

    public ICackleLoginWidget Login() => new CackleLoginWidget();
  }
}