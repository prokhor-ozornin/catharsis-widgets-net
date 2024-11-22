using Catharsis.Commons;
using Xunit;

namespace Catharsis.Web.Widgets.Tests;

/// <summary>
///   <para>Tests set for class <see cref="ILiveJournalWidgetsCreatorExtensions"/>.</para>
/// </summary>
public sealed class ILiveJournalWidgetsCreatorExtensionsTests : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="ILiveJournalWidgetsCreatorExtensions.LikeButton(ILiveJournalWidgetsCreator, Action{ILiveJournalLikeButtonWidget}"/> method.</para></summary>
  [Fact]
  public void LikeButton_Method()
  {
    Assert.Throws<ArgumentNullException>(() => ILiveJournalWidgetsCreatorExtensions.LikeButton(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new LiveJournalWidgetsCreator().LikeButton(null));

    Assert.Equal(new LiveJournalWidgetsCreator().LikeButton().ToHtml(), new LiveJournalWidgetsCreator().LikeButton(_ => { }));
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ILiveJournalWidgetsCreatorExtensions.RepostButton(ILiveJournalWidgetsCreator, Action{ILiveJournalRepostButtonWidget}"/> method.</para></summary>
  [Fact]
  public void RepostButton_Method()
  {
    Assert.Throws<ArgumentNullException>(() => ILiveJournalWidgetsCreatorExtensions.RepostButton(null, _ => { }));
    Assert.Throws<ArgumentNullException>(() => new LiveJournalWidgetsCreator().RepostButton(null));

    Assert.Equal(new LiveJournalWidgetsCreator().RepostButton().ToHtml(), new LiveJournalWidgetsCreator().RepostButton(_ => { }));
  }
}