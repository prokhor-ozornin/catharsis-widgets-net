using Xunit;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Tests set for class <see cref="ILiveJournalWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed class LiveJournalWidgetsCreatorExtensionsTests
{
  /// <summary>
  ///   <para>Performs testing of <see cref="ILiveJournalWidgetsCreatorExtensions.LikeButton(ILiveJournalWidgetsCreator, Action{ILiveJournalLikeButtonWidget}"/> method.</para></summary>
  [Fact]
  public void LikeButton_Method()
  {
    Assert.Throws<ArgumentNullException>(() => ILiveJournalWidgetsCreatorExtensions.LikeButton(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new LiveJournalWidgetsCreator().LikeButton(null));

    Assert.Equal(new LiveJournalWidgetsCreator().LikeButton().ToHtml(), new LiveJournalWidgetsCreator().LikeButton(x => { }));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ILiveJournalWidgetsCreatorExtensions.RepostButton(ILiveJournalWidgetsCreator, Action{ILiveJournalRepostButtonWidget}"/> method.</para></summary>
  [Fact]
  public void RepostButton_Method()
  {
    Assert.Throws<ArgumentNullException>(() => ILiveJournalWidgetsCreatorExtensions.RepostButton(null, widget => { }));
    Assert.Throws<ArgumentNullException>(() => new LiveJournalWidgetsCreator().RepostButton(null));

    Assert.Equal(new LiveJournalWidgetsCreator().RepostButton().ToHtml(), new LiveJournalWidgetsCreator().RepostButton(x => { }));
  }
}