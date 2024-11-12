namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IDisqusHtmlHelper"/>
public class DisqusHtmlHelper : IDisqusHtmlHelper
{
  /// <inheritdoc cref="IDisqusHtmlHelper.Comments()"/>
  public IDisqusCommentsWidget Comments() => new DisqusCommentsWidget();
}