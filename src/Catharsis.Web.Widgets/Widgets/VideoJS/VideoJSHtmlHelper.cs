namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVideoJSHtmlHelper"/>
public class VideoJSHtmlHelper : IVideoJSHtmlHelper
{
  /// <inheritdoc cref="IVideoJSHtmlHelper.Player()"/>
  public IVideoJSPlayerWidget Player() => new VideoJSPlayerWidget();
}