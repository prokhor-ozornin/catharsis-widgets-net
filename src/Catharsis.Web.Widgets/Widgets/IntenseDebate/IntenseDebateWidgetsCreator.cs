namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IIntenseDebateWidgetsCreator"/>
public class IntenseDebateWidgetsCreator : IIntenseDebateWidgetsCreator
{
  /// <inheritdoc cref="IIntenseDebateWidgetsCreator.Comments()"/>
  public virtual IIntenseDebateCommentsWidget Comments() => new IntenseDebateCommentsWidget();

  /// <inheritdoc cref="IIntenseDebateWidgetsCreator.Link()"/>
  public virtual IIntenseDebateLinkWidget Link() => new IntenseDebateLinkWidget();
}