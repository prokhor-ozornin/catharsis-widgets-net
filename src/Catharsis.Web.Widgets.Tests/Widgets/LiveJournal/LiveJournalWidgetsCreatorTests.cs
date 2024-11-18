using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="LiveJournalWidgetsCreator"/>.</para>
/// </summary>
public sealed class LiveJournalWidgetsCreatorTests
{
  private readonly ILiveJournalWidgetsCreator widgets = Widgets.Web.LiveJournal();

  /// <summary>
  ///   <para>Performs testing of <see cref="LiveJournalWidgetsCreator.LikeButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void LikeButton_Method()
  {
    Assert.False(ReferenceEquals(widgets.LikeButton(), widgets.LikeButton()));
    Assert.True(widgets.LikeButton() is LiveJournalLikeButtonWidget);
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="LiveJournalWidgetsCreator.RepostButton()"/> method.</para>
  /// </summary>
  [Fact]
  public void RepostButton_Method()
  {
    Assert.False(ReferenceEquals(widgets.RepostButton(), widgets.RepostButton()));
    Assert.True(widgets.RepostButton() is LiveJournalRepostButtonWidget);
  }
}