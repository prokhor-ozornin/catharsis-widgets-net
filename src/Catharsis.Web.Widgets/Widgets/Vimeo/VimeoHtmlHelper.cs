namespace Catharsis.Web.Widgets;

internal sealed class VimeoHtmlHelper : IVimeoHtmlHelper
{
  public IVimeoVideoWidget Video() => new VimeoVideoWidget();
}