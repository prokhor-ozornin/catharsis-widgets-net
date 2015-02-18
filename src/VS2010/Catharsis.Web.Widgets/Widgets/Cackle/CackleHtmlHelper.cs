namespace Catharsis.Web.Widgets
{
  internal sealed class CackleHtmlHelper : ICackleHtmlHelper
  {
    public ICackleCommentsWidget Comments()
    {
      return new CackleCommentsWidget();
    }

    public ICackleCommentsCountWidget CommentsCount()
    {
      return new CackleCommentsCountWidget();
    }

    public ICackleLatestCommentsWidget LatestComments()
    {
      return new CackleLatestCommentsWidget();
    }

    public ICackleLoginWidget Login()
    {
      return new CackleLoginWidget();
    }
  }
}