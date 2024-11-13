namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IRuTubeWidgetCreator"/>
public class RuTubeWidgetCreator : IRuTubeWidgetCreator
{
  /// <inheritdoc cref="IRuTubeWidgetCreator.Video()"/>
  public IRuTubeVideoWidget Video() => new RuTubeVideoWidget();
}