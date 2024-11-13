namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ILiveJournalWidgetsCreator"/>
public class LiveJournalWidgetsCreator : ILiveJournalWidgetsCreator
{
  /// <inheritdoc cref="ILiveJournalWidgetsCreator.LikeButton()"/>
  public ILiveJournalLikeButtonWidget LikeButton() => new LiveJournalLikeButtonWidget();

  /// <inheritdoc cref="ILiveJournalWidgetsCreator.RepostButton()"/>
  public ILiveJournalRepostButtonWidget RepostButton() => new LiveJournalRepostButtonWidget();
}