namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IIntenseDebateWidgetsCreator"/>
public class IntenseDebateWidgetsCreator : IIntenseDebateWidgetsCreator
{
  /// <inheritdoc cref="IIntenseDebateWidgetsCreator.Comments()"/>
  public IIntenseDebateCommentsWidget Comments() => new IntenseDebateCommentsWidget();

  /// <inheritdoc cref="IIntenseDebateWidgetsCreator.Link()"/>
  public IIntenseDebateLinkWidget Link() => new IntenseDebateLinkWidget();
}