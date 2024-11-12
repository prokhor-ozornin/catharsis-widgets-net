namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVimeoHtmlHelper"/>
public class VimeoHtmlHelper : IVimeoHtmlHelper
{
  /// <inheritdoc cref="IVimeoHtmlHelper.Video()"/>
  public IVimeoVideoWidget Video() => new VimeoVideoWidget();
}