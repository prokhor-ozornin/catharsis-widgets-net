namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVimeoWidgetsCreator"/>
public class VimeoWidgetsCreator : IVimeoWidgetsCreator
{
  /// <inheritdoc cref="IVimeoWidgetsCreator.Video()"/>
  public IVimeoVideoWidget Video() => new VimeoVideoWidget();
}