namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IRuTubeWidgetsCreator"/>
public class RuTubeWidgetsCreator : IRuTubeWidgetsCreator
{
  /// <inheritdoc cref="IRuTubeWidgetsCreator.Video()"/>
  public virtual IRuTubeVideoWidget Video() => new RuTubeVideoWidget();
}