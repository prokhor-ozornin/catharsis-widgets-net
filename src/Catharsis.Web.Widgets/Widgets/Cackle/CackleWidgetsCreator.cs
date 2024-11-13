namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ICackleWidgetsCreator"/>
public class CackleWidgetsCreator : ICackleWidgetsCreator
{
  /// <inheritdoc cref="ICackleWidgetsCreator.Comments()"/>
  public ICackleCommentsWidget Comments() => new CackleCommentsWidget();

  /// <inheritdoc cref="ICackleWidgetsCreator.CommentsCount()"/>
  public ICackleCommentsCountWidget CommentsCount() => new CackleCommentsCountWidget();

  /// <inheritdoc cref="ICackleWidgetsCreator.LatestComments()"/>
  public ICackleLatestCommentsWidget LatestComments() => new CackleLatestCommentsWidget();

  /// <inheritdoc cref="ICackleWidgetsCreator.Login()"/>
  public ICackleLoginWidget Login() => new CackleLoginWidget();
}