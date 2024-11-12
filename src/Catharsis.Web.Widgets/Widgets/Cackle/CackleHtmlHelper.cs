namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ICackleHtmlHelper"/>
public class CackleHtmlHelper : ICackleHtmlHelper
{
  /// <inheritdoc cref="ICackleHtmlHelper.Comments()"/>
  public ICackleCommentsWidget Comments() => new CackleCommentsWidget();

  /// <inheritdoc cref="ICackleHtmlHelper.CommentsCount()"/>
  public ICackleCommentsCountWidget CommentsCount() => new CackleCommentsCountWidget();

  /// <inheritdoc cref="ICackleHtmlHelper.LatestComments()"/>
  public ICackleLatestCommentsWidget LatestComments() => new CackleLatestCommentsWidget();

  /// <inheritdoc cref="ICackleHtmlHelper.Login()"/>
  public ICackleLoginWidget Login() => new CackleLoginWidget();
}