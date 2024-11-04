namespace Catharsis.Web.Widgets
{
  internal sealed class LiveJournalHtmlHelper : ILiveJournalHtmlHelper
  {
    public ILiveJournalLikeButtonWidget LikeButton()
    {
      return new LiveJournalLikeButtonWidget();
    }

    public ILiveJournalRepostButtonWidget RepostButton()
    {
      return new LiveJournalRepostButtonWidget();
    }
  }
}