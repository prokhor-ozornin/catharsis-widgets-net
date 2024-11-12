namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IShare42HtmlHelper"/>
public class Share42HtmlHelper : IShare42HtmlHelper
{
  /// <inheritdoc cref="IShare42HtmlHelper.Panel()"/>
  public IShare42PanelWidget Panel() => new Share42PanelWidget();
}