namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ILiveJournalWidgetsCreator"/>
public class LiveJournalWidgetsCreator : ILiveJournalWidgetsCreator
{
  /// <inheritdoc cref="ILiveJournalWidgetsCreator.LikeButton()"/>
  public virtual ILiveJournalLikeButtonWidget LikeButton() => new LiveJournalLikeButtonWidget();

  /// <inheritdoc cref="ILiveJournalWidgetsCreator.RepostButton()"/>
  public virtual ILiveJournalRepostButtonWidget RepostButton() => new LiveJournalRepostButtonWidget();
}