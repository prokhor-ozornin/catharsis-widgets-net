namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IDisqusWidgetsCreator"/>
public class DisqusWidgetsCreator : IDisqusWidgetsCreator
{
  /// <inheritdoc cref="IDisqusWidgetsCreator.Comments()"/>
  public virtual IDisqusCommentsWidget Comments() => new DisqusCommentsWidget();
}