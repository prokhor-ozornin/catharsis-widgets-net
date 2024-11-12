namespace Catharsis.Web.Widgets
{
  internal sealed class LiveJournalHtmlHelper : ILiveJournalHtmlHelper
  {
    public ILiveJournalLikeButtonWidget LikeButton() => new LiveJournalLikeButtonWidget();

    public ILiveJournalRepostButtonWidget RepostButton() => new LiveJournalRepostButtonWidget();
  }
}