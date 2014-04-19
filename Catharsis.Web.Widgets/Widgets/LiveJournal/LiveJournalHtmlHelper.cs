namespace Catharsis.Web.Widgets
{
  internal sealed class LiveJournalHtmlHelper : ILiveJournalHtmlHelper
  {
    public ILiveJournalLikeButtonWidget Like()
    {
      return new LiveJournalLikeButtonWidget();
    }

    public ILiveJournalRepostButtonWidget Repost()
    {
      return new LiveJournalRepostButtonWidget();
    }
  }
}