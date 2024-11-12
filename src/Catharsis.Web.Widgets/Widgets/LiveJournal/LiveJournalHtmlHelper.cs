namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ILiveJournalHtmlHelper"/>
public class LiveJournalHtmlHelper : ILiveJournalHtmlHelper
{
  /// <inheritdoc cref="ILiveJournalHtmlHelper.LikeButton()"/>
  public ILiveJournalLikeButtonWidget LikeButton() => new LiveJournalLikeButtonWidget();

  /// <inheritdoc cref="ILiveJournalHtmlHelper.RepostButton()"/>
  public ILiveJournalRepostButtonWidget RepostButton() => new LiveJournalRepostButtonWidget();
}