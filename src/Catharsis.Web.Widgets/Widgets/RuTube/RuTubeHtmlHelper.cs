namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IRuTubeHtmlHelper"/>
public class RuTubeHtmlHelper : IRuTubeHtmlHelper
{
  /// <inheritdoc cref="IRuTubeHtmlHelper.Video()"/>
  public IRuTubeVideoWidget Video() => new RuTubeVideoWidget();
}