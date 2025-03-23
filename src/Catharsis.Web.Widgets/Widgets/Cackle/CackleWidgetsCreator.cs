namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ICackleWidgetsCreator"/>
public class CackleWidgetsCreator : ICackleWidgetsCreator
{
  /// <inheritdoc cref="ICackleWidgetsCreator.Comments()"/>
  public virtual ICackleCommentsWidget Comments() => new CackleCommentsWidget();

  /// <inheritdoc cref="ICackleWidgetsCreator.CommentsCount()"/>
  public virtual ICackleCommentsCountWidget CommentsCount() => new CackleCommentsCountWidget();

  /// <inheritdoc cref="ICackleWidgetsCreator.LatestComments()"/>
  public virtual ICackleLatestCommentsWidget LatestComments() => new CackleLatestCommentsWidget();

  /// <inheritdoc cref="ICackleWidgetsCreator.Login()"/>
  public virtual ICackleLoginWidget Login() => new CackleLoginWidget();
}