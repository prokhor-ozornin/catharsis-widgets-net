namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVimeoWidgetCreator"/>
public class VimeoWidgetCreator : IVimeoWidgetCreator
{
  /// <inheritdoc cref="IVimeoWidgetCreator.Video()"/>
  public IVimeoVideoWidget Video() => new VimeoVideoWidget();
}